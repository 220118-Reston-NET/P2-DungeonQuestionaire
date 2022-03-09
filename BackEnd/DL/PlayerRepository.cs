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
                                values (@playername, @spriteimgurl, @hp, @enemycurrentlyfighting, @useremail, @userpassword, @uservictories)";



            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                await con.OpenAsync();
                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@playername", p_resource.PlayerName);
                command.Parameters.AddWithValue("@spriteimgurl", p_resource.SpriteURL);
                command.Parameters.AddWithValue("@hp", p_resource.PlayerHP);
                command.Parameters.AddWithValue("@enemycurrentlyfighting", p_resource.EnemyCurrentlyFighting);
                command.Parameters.AddWithValue("@useremail", p_resource.UserEmail);
                command.Parameters.AddWithValue("@userpassword", p_resource.UserPassword);
                command.Parameters.AddWithValue("@uservictories", p_resource.UserVictories);
                await command.ExecuteNonQueryAsync();
            }
            return p_resource;
        }

        public async Task<List<Player>> GetAll()
        {
            List<Player> listofAllPlayers = new List<Player>();
            string sqlQuery = @"select * from player";
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
                        EnemyCurrentlyFighting = reader.GetInt32(4),
                        UserEmail = reader.GetString(5),
                        UserPassword = reader.GetString(6)
                    });
                }
            }
            return listofAllPlayers;
        }

        public async Task<Player> Update(Player p_resource)
        {
            string sqlQuery = @"Update Player
                                Set PlayerName = @PlayerName, SpriteImgurl = @SpriteImgurl, hp = @PlayerHP, EnemyCurrentlyFighting = @EnemyCurrentlyFighting, UserEmail = @UserEmail, UserPassword = @UserPassword, UserVictories = @UserVictories
                                Where PlayerID = @PlayerID";
            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                await con.OpenAsync();
                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@PlayerID", p_resource.PlayerID);
                command.Parameters.AddWithValue("@PlayerName", p_resource.PlayerName);
                command.Parameters.AddWithValue("@SpriteImgurl", p_resource.SpriteURL);
                command.Parameters.AddWithValue("@PlayerHP", p_resource.PlayerHP);
                command.Parameters.AddWithValue("@EnemyCurrentlyFighting", p_resource.EnemyCurrentlyFighting);
                command.Parameters.AddWithValue("@UserEmail", p_resource.UserEmail);
                command.Parameters.AddWithValue("@UserPassword", p_resource.UserPassword);
                command.Parameters.AddWithValue("@UserVictories", p_resource.UserVictories);
                command.ExecuteNonQueryAsync();
            }
            return p_resource;
        }

        public async Task<Player> Delete(Player p_resource)
        {
            string sqlQuery = @"Delete from Player
                                Where PlayerID = @PlayerID";
            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                await con.OpenAsync();
                SqlCommand com = new SqlCommand(sqlQuery, con);
                com.Parameters.AddWithValue("@PlayerID", p_resource.PlayerID);
                com.ExecuteNonQueryAsync();
            }
            return p_resource;
        }


    }
}