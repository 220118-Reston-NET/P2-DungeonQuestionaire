using Models;
namespace BL
{
    public interface IQuestionBL
    {

        Task<Question> AddQuestion(Question p_Question);

        Task<List<Question>> GetAllQuestions();

        Task<Question> UpdateQuestion(Question p_Question);

        Task<Question> DeleteQuestion(Question p_Question);




    }
}