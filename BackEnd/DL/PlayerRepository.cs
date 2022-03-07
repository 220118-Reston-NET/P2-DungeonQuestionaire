using System.Data.SqlClient;

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

                SqlCommand com = SqlCommand(sqlQuery, con);

            }
            return p_resource;
        }

        public Player GetAll(Player p_resource)
        {
            string sqlQuery = @"";
            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();

                SqlCommand com = SqlCommand(sqlQuery, con);

            }
            return p_resource;
        }

        public Player Update(Player p_resource)
        {
            string sqlQuery = @"";
            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();

                SqlCommand com = SqlCommand(sqlQuery, con);

            }
            return p_resource;
        }

        public Player Delete(Player p_resource)
        {
            string sqlQuery = @"";
            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();

                SqlCommand com = SqlCommand(sqlQuery, con);

            }
            return p_resource;
        }


    }
}