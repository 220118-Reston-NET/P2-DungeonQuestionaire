using Moq;
using Xunit;
using ModelApi;
using DL;
using BL;
using System.Collections.Generic;
namespace P2_DungeonQuestionnaire
{
    public class QuestionBLTesting{

        [Fact]
        public void Should_Add_Question()
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

            Mock<IRepository<Question> _mockRepo = Mock<IRepository<Question>();

            _mockRepo.Setup(repo => repo.Add(_expectedQuestion)).returns(_expectedQuestion);

            IQuestionBL _QuestionBL = new QuestionBL(_mockRepo.Object);

            Question _actualQuestion = new Question();
            _actualQuestion = _expectedQuestion;

            //Act
            _actualQuestion = _QuestionBL.AddQuestion(_actualQuestion);

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
        public void Should_Get_All_Question()
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

            Mock<IRepository<Question> _mockRepo = Mock<IRepository<Question>();

            _mockRepo.Setup(repo => repo.GetAll()).returns(_expectedListOfQuestion);

            IQuestionBL _QuestionBL = new QuestionBL(_mockRepo.Object);

            List<Question> _actualListOfQuestion = new List<Question>();
            _actualListOfQuestion = _expectedListOfQuestion;

            //Act
            _actualListOfQuestion = _QuestionBL.GetAllQuestion(_actualListOfQuestion);

            //Assert
            Assert.Same(_expectedListOfQuestion,  _actualListOfQuestion);
            Assert.Equal(_expectedListOfQuestion[0].QuestionID, _actualListOfQuestion[0].QuestionID);
            Assert.Equal(_expectedListOfQuestion[1].Answer1, _actualListOfQuestion[1].Answer1);
            Assert.Equal(_expectedListOfQuestion[2].Answer2, _actualListOfQuestion[2].Answer2);
            Assert.Equal(_expectedListOfQuestion[3].Answer3, _actualListOfQuestion[3].Answer3);
            Assert.Equal(_expectedListOfQuestion[4].Answer4, _actualListOfQuestion[4].Answer4);
            Assert.Equal(_expectedListOfQuestion[5].Category, _actualListOfQuestion[5].Category);
            Assert.Equal(_expectedListOfQuestion[6].CorrectAnswer, _actualListOfQuestion[6].CorrectAnswer);
            Assert.Equal(_expectedListOfQuestion[7].DamageValue, _actualListOfQuestion[7].DamageValue);
            
        }
    }