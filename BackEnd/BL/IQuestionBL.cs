using ModelApi;
namespace BL
{
    public interface IQuestionBL
    {

        Question AddQuestion(Question p_Question);

        List<Question> GetAllQuestion();

        Question UpdateQuestion(Question p_Question);

        Question DeleteQuestion(Question p_Question);




    }
}