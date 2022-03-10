using Models;
namespace BL
{
    public interface IQuestionBL
    {

        Task<Question> AddQuestion(Question p_Question);

        Task<List<Question>> GetAllQuestion();

        Task<Question> UpdateQuestion(Question p_Question);

        Task<Question> DeleteQuestion(Question p_Question);




    }
}