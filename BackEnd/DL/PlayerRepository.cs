using System.Data.SqlClient;
using Models;

namespace DL
{
    public class PlayerRepository : IRepository<Player>
    {

        /// <summary>
        /// PlayerRepository will require a connection string to be able to create an object out of it.
        /// </summary>

        private readonly string _connectionStrings;
        public PlayerRepository(string p_connectionStrings)
        {
            _connectionStrings = p_connectionStrings;
        }

        public async Task<Player> Add(Player p_resource)
        {
            string sqlQuery = @"insert into Player 
                                values (@playername, @spriteimgurl, @hp, @useremail, @userpassword, @uservictories, @enemycurrentlyfighting)";

            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                await con.OpenAsync();
                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@playername", p_resource.PlayerName);
                command.Parameters.AddWithValue("@spriteimgurl", p_resource.SpriteURL);
                command.Parameters.AddWithValue("@hp", p_resource.PlayerHP);
                command.Parameters.AddWithValue("@useremail", p_resource.UserEmail);
                command.Parameters.AddWithValue("@userpassword", p_resource.UserPassword);
                command.Parameters.AddWithValue("@uservictories", p_resource.UserVictories);
                command.Parameters.AddWithValue("@enemycurrentlyfighting", p_resource.EnemyCurrentlyFighting);
                await command.ExecuteNonQueryAsync();
            }
            return p_resource;
        }

        public async Task<List<Player>> GetAll()
        {
            List<Player> listofAllPlayers = new List<Player>();
            string sqlQuery = @"select * from Player";
            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                await con.OpenAsync();
                SqlCommand command = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = await command.ExecuteReaderAsync();
                while (reader.Read())
                {
                    listofAllPlayers.Add(new Player()
                    {
                        PlayerID = reader.GetInt32(0),
                        PlayerName = reader.GetString(1),
                        SpriteURL = reader.GetString(2),
                        PlayerHP = reader.GetInt32(3),
                        UserEmail = reader.GetString(4),
                        UserPassword = reader.GetString(5),
                        UserVictories = reader.GetInt32(6),
                        EnemyCurrentlyFighting = reader.GetInt32(7)
                    });
                }
            }
            return listofAllPlayers;
        }

        public async Task Update(string SpriteImgurl, int PlayerHP, int EnemyCurrentlyFighting, string UserEmail, int UserVictories)
        {
            string sqlQuery = @"Update Player
                                Set SpriteImgurl = @SpriteImgurl, hp = @PlayerHP, EnemyCurrentlyFighting = @EnemyCurrentlyFighting,  UserVictories = @UserVictories
                                Where UserEmail = @UserEmail";
            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                await con.OpenAsync();
                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@SpriteImgurl", SpriteImgurl );
                command.Parameters.AddWithValue("@PlayerHP", PlayerHP);
                command.Parameters.AddWithValue("@EnemyCurrentlyFighting", EnemyCurrentlyFighting);
                command.Parameters.AddWithValue("@UserEmail", UserEmail);
                command.Parameters.AddWithValue("@UserVictories", UserVictories);
                await command.ExecuteNonQueryAsync();
            }
            
        }

        public async Task<Player> Delete(Player p_resource)
        {
            string sqlQuery = @"Delete from Player
                                Where PlayerID = @PlayerID";
            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                await con.OpenAsync();
                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@PlayerID", p_resource.PlayerID);
                await command.ExecuteNonQueryAsync();
            }
            return p_resource;
        }

        public Task<Player> Update(Player p_resource)
        {
            throw new NotImplementedException();
        }
    }
}