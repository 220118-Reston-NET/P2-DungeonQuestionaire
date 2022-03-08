using System.Data.SqlClient;
using ModelApi;

namespace DL
{
    public class PlayerRepository : IRepository<Player>
    {

        public Player Add(Player p_resource)
        {
            string sqlQuery = @"insert into player (playername, spriteimgurl, hp, enemycurrentlyfighting, useremail,userpassword,uservictories)
                values ('TestPlayer', 'TestIMGURL', 1, 1, 'test@email.com', 'TestPassword', 1)";

            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();

                SqlCommand com = new SqlCommand(sqlQuery, con);

            }
            return p_resource;
        }

        public List<Player> GetAll()
        {
            List<Player> listofAllQuestions = new List<Player>();
            string sqlQuery = @"";
            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();

                SqlCommand com = new SqlCommand(sqlQuery, con);

            }
            return listofAllQuestions;
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