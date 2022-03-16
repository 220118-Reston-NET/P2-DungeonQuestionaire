global using Serilog;
using DL;
using Models;
using BL;


var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration().WriteTo.File("./Logs/server.txt").CreateLogger();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRepository<Player>>(repo => new PlayerRepository(builder.Configuration.GetConnectionString("Reference2DB")));
builder.Services.AddScoped<IRepository<Enemy>>(repo => new EnemyRepository(builder.Configuration.GetConnectionString("Reference2DB")));
builder.Services.AddScoped<IEnemyBL, EnemyBL>();
builder.Services.AddScoped<IRepository<Question>>(repo => new QuestionRepository(builder.Configuration.GetConnectionString("Reference2DB")));
builder.Services.AddScoped<IQuestionBL, QuestionBL>();
builder.Services.AddScoped<IPlayerBL, PlayerBL>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
