using System.Data.SqlClient;

namespace DL
{
    public class QuestionRepository : IRepository<Question>
    {

        public Question Add(Question p_resource)
        {
            string sqlQuery = @"";

            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();

                SqlCommand com = SqlCommand(sqlQuery, con);

            }
            return p_resource;
        }

        public Question GetAll(Question p_resource)
        {
            string sqlQuery = @"";
            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();

                SqlCommand com = SqlCommand(sqlQuery, con);

            }
            return p_resource;
        }

        public Question Update(Question p_resource)
        {
            string sqlQuery = @"";
            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();

                SqlCommand com = SqlCommand(sqlQuery, con);

            }
            return p_resource;
        }

        public Question Delete(Question p_resource)
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