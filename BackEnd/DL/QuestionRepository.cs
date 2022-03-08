using System.Data.SqlClient;
using ModelApi;

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

                SqlCommand com = new SqlCommand(sqlQuery, con);

            }
            return p_resource;
        }

        public List<Question> GetAll()
        {
            List<Question> listofAllQuestions = new List<Question>();
            string sqlQuery = @"select * from question";
            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    listofAllQuestions.Add(new Question(){
                            QuestionID = reader.GetInt32(0),
                            Answer1 = reader.GetString(1),
                            Answer2 = reader.GetString(2),
                            Answer3 = reader.GetString(3),
                            Answer4 = reader.GetString(4),
                            Category = reader.GetString(5),
                            CorrectAnswer = reader.GetString(6),
                            DamageValue = reader.GetInt32(7)
                    });
                }

            }
            return listofAllQuestions;
        }

        public Question Update(Question p_resource)
        {
            string sqlQuery = @"";
            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();

                SqlCommand com = new SqlCommand(sqlQuery, con);

            }
            return p_resource;
        }

        public Question Delete(Question p_resource)
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