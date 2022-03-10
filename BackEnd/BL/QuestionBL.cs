using DL;
using Models;

namespace BL
{
    public class QuestionBL : IQuestionBL
    {

        private IRepository<Question> _repo;
        public QuestionBL(IRepository<Question> p_repo)
        {

            _repo = p_repo;
        }
        public async Task<Question> AddQuestion(Question p_Question)
        {
            return await _repo.Add(p_Question);
        }

        public async Task<Question> DeleteQuestion(Question p_Question)
        {
            return await _repo.Delete(p_Question);
        }

        public async Task<List<Question>> GetAllQuestions()
        {
            return await _repo.GetAll();
        }

        public async Task<Question> UpdateQuestion(Question p_Question)
        {
            return await _repo.Update(p_Question);
        }
    }
}