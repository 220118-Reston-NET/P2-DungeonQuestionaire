using System.Data.SqlClient;
using ModelApi;

namespace DL
{
    public class QuestionRepository : IRepository<Question>
    {

        public Question Add(Question p_resource)
        {
            string sqlQuery = @"insert into question 
                                values (@answer1, @answer2, @answer3, @answer4, @category, @correctanswer, @damagevalue)";

            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();
                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@answer1", p_resource.Answer1);
                command.Parameters.AddWithValue("@answer2", p_resource.Answer2);
                command.Parameters.AddWithValue("@answer3", p_resource.Answer3);
                command.Parameters.AddWithValue("@answer4", p_resource.Answer4);
                command.Parameters.AddWithValue("@category", p_resource.Category);
                command.Parameters.AddWithValue("@correctanswer", p_resource.CorrectAnswer);
                command.Parameters.AddWithValue("@damagevalue", p_resource.DamageValue);
                command.ExecuteNonQuery();
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
            string sqlQuery = @"Update question 
                                Set QuestionID = @QuestionID, Answer1 = @Answer1, Answer2 = @Answer2, Answer3 = @Answer3, Answer4 = @Answer4, Category = @Category, CorrectAnswer = @CorrectAnswer, DamageValue = @DamageValue
                                Where QuestionID = @QuestionID";
            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();
                SqlCommand com = new SqlCommand(sqlQuery, con);
                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@QuestionID", p_resource.QuestionID);
                command.Parameters.AddWithValue("@Answer1", p_resource.Answer1);
                command.Parameters.AddWithValue("@Answer2", p_resource.Answer2);
                command.Parameters.AddWithValue("@Answer3", p_resource.Answer3);
                command.Parameters.AddWithValue("@Answer4", p_resource.Answer4);
                command.Parameters.AddWithValue("@Category", p_resource.Category);
                command.Parameters.AddWithValue("@CorrectAnswer", p_resource.CorrectAnswer);
                command.Parameters.AddWithValue("@DamageValue", p_resource.DamageValue);
                command.ExecuteNonQuery();

            }
            return p_resource;
        }

        public Question Delete(Question p_resource)
        {
            string sqlQuery = @"Delete from Question
                                Where QuestionID = @QuestionId";
            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();
                SqlCommand com = new SqlCommand(sqlQuery, con);
                com.Parameters.AddWithValue("@QuestionId", p_resource.QuestionID);
                com.ExecuteNonQuery();
            }
            return p_resource;
        }


    }
}