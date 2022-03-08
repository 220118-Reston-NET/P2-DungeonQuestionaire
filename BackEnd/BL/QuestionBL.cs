using DL;
using ModelApi;

namespace BL
{
    public class QuestionBL : IQuestionBL
    {

        private IRepository<Question> _repo;
        public QuestionBL(IRepository<Question> p_repo)
        {

            _repo = p_repo;
        }
        public Question AddQuestion(Question p_Question)
        {
            return _repo.Add(p_Question);
        }

        public Question DeleteQuestion(Question p_Question)
        {
            return _repo.Delete(p_Question);
        }

        public List<Question> GetAllQuestion()
        {
            return _repo.GetAll();
        }

        public Question UpdateQuestion(Question p_Question)
        {
            return _repo.Update(p_Question);
        }
    }
}