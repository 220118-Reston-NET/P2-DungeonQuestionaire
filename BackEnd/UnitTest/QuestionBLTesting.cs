using Moq;
using Xunit;
using Models;
using DL;
using BL;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace P2_DungeonQuestionnaire
{
    public class QuestionBLTesting
    {

        [Fact]
        public async Task Should_Add_Question()
        {
            //Assert
            Question _expectedQuestion = new Question()
            {
                QuestionID = 1,
                Answer1 = "TestAnswer",
                Answer2 = "TestAnswer2",
                Answer3 = "TestAnswer3",
                Answer4 = "TestAnswer4",
                Category = "TestCategory",
                CorrectAnswer = "TestCorrectAnswer",
                DamageValue = 1

            };

            Mock<IRepository<Question>> _mockRepo = new Mock<IRepository<Question>>();

            _mockRepo.Setup(repo => repo.Add(_expectedQuestion)).ReturnsAsync(_expectedQuestion);

            IQuestionBL _QuestionBL = new QuestionBL(_mockRepo.Object);

            Question _actualQuestion = new Question();
            _actualQuestion = _expectedQuestion;

            //Act
            _actualQuestion = await _QuestionBL.AddQuestion(_actualQuestion);

            //Assert
            Assert.Same(_expectedQuestion, _actualQuestion);
            Assert.Equal(_expectedQuestion.QuestionID, _actualQuestion.QuestionID);
            Assert.Equal(_expectedQuestion.Answer1, _actualQuestion.Answer1);
            Assert.Equal(_expectedQuestion.Answer2, _actualQuestion.Answer2);
            Assert.Equal(_expectedQuestion.Answer3, _actualQuestion.Answer3);
            Assert.Equal(_expectedQuestion.Answer4, _actualQuestion.Answer4);
            Assert.Equal(_expectedQuestion.Category, _actualQuestion.Category);
            Assert.Equal(_expectedQuestion.CorrectAnswer, _actualQuestion.CorrectAnswer);
            Assert.Equal(_expectedQuestion.DamageValue, _actualQuestion.DamageValue);
        }


        [Fact]
        public async Task Should_Get_All_Question()
        {
            //Assert
            List<Question> _expectedListOfQuestion = new List<Question>();

            Question _Question = new Question()
            {
                QuestionID = 1,
                Answer1 = "TestAnswer",
                Answer2 = "TestAnswer2",
                Answer3 = "TestAnswer3",
                Answer4 = "TestAnswer4",
                Category = "TestCategory",
                CorrectAnswer = "TestCorrectAnswer",
                DamageValue = 1

            };

            _expectedListOfQuestion.Add(_Question);

            Mock<IRepository<Question>> _mockRepo = new Mock<IRepository<Question>>();

            _mockRepo.Setup(repo => repo.GetAll()).ReturnsAsync(_expectedListOfQuestion);

            IQuestionBL _QuestionBL = new QuestionBL(_mockRepo.Object);

            List<Question> _actualListOfQuestion = new List<Question>();
            _actualListOfQuestion = _expectedListOfQuestion;

            //Act
            _actualListOfQuestion = await _QuestionBL.GetAllQuestions();

            //Assert
            Assert.Same(_expectedListOfQuestion, _actualListOfQuestion);
            Assert.Equal(_expectedListOfQuestion[0].QuestionID, _actualListOfQuestion[0].QuestionID);
            Assert.Equal(_expectedListOfQuestion[0].Answer1, _actualListOfQuestion[0].Answer1);
            Assert.Equal(_expectedListOfQuestion[0].Answer2, _actualListOfQuestion[0].Answer2);
            Assert.Equal(_expectedListOfQuestion[0].Answer3, _actualListOfQuestion[0].Answer3);
            Assert.Equal(_expectedListOfQuestion[0].Answer4, _actualListOfQuestion[0].Answer4);
            Assert.Equal(_expectedListOfQuestion[0].Category, _actualListOfQuestion[0].Category);
            Assert.Equal(_expectedListOfQuestion[0].CorrectAnswer, _actualListOfQuestion[0].CorrectAnswer);
            Assert.Equal(_expectedListOfQuestion[0].DamageValue, _actualListOfQuestion[0].DamageValue);

        }
    }
}