using System.Data.SqlClient;
using ModelApi;

namespace DL
{
    public class PlayerRepository : IRepository<Player>
    {

        public Player Add(Player p_resource)
        {
            string sqlQuery = @"";

            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();

                SqlCommand com = new SqlCommand(sqlQuery, con);

            }
            return p_resource;
        }

        public List<Player> GetAll()
        {
            List<Player> listofAllPlayers = new List<Player>();
            string sqlQuery = @"select * from player";
            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();
                SqlCommand command = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    listofAllPlayers.Add(new Player(){
                            PlayerID = reader.GetInt32(0),
                            PlayerName = reader.GetString(1),
                            SpriteURL = reader.GetString(2),
                            PlayerHP = reader.GetInt32(3),
                            EnemyCurrentFighting = reader.GetInt32(4),
                            UserEmail = reader.GetString(5),
                            UserPassword = reader.GetString(6)
                    });
                }
            }
            return listofAllPlayers;
        }

        public Player Update(Player p_resource)
        {
            string sqlQuery = @"";
            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();

                SqlCommand com = new SqlCommand(sqlQuery, con);

            }
            return p_resource;
        }

        public Player Delete(Player p_resource)
        {
            string sqlQuery = @"";
            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();

                SqlCommand com = new SqlCommand(sqlQuery, con);

            }
            return p_resource;
        }


    }
}