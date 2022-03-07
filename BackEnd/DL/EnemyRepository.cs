using System.Data.SqlClient;

namespace DL
{
    public class EnemyRepository : IRepository<Enemy>
    {

        public Enemy Add(Enemy p_resource)
        {
            string sqlQuery = @"";

            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();

                SqlCommand com = SqlCommand(sqlQuery, con);

            }
            return p_resource;
        }

        public Enemy GetAll(Enemy p_resource)
        {
            string sqlQuery = @"";
            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();

                SqlCommand com = SqlCommand(sqlQuery, con);

            }
            return p_resource;
        }

        public Enemy Update(Enemy p_resource)
        {
            string sqlQuery = @"";
            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();

                SqlCommand com = SqlCommand(sqlQuery, con);

            }
            return p_resource;
        }

        public Enemy Delete(Enemy p_resource)
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