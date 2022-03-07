using ModelApi;
using Xunit;
namespace P2_DungeonQuestionnaire
{
    public class QuestionTesting
    {

        [Fact]
        public void SetValidQuestionID()
        {

            //Arrange
            Question _quest = new Question();
            int validQuestionID = 1;

            //Act
            _quest.QuestionID = validQuestionID;

            //Assert
            Assert.NotNull(_quest.QuestionID);

            //Assert
            Assert.NotNull(_quest.QuestionID);
            Assert.Equal(validQuestionID, _quest.QuestionID);

        }

        [Fact]
        public void SetValidQuestionQuestions()
        {

            //Arrange
            Question _quest = new Question();
            string validQuestion = "Test Question";

            //Act
            _quest.Questions = validQuestion;

            //Assert
            Assert.NotNull(_quest.Questions);
            Assert.Equal(validQuestion, _quest.Questions);
        }

        [Fact]
        public void SetValidQuestionAnswer()
        {

            //Arrange
            Question _quest = new Question();
            string validAnswer = "Test Answer";

            //Act
            _quest.Answers = validAnswer;

            //Assert
            Assert.NotNull(_quest.Answers);
            Assert.Equal(validAnswer, _quest.Answers);
        }

        [Fact]
        public void SetValidCategory()
        {

            //Arrange
            Question _quest = new Question();
            string validCategory = "testCategory";

            //Act
            _quest.Category = validCategory;

            //Assert
            Assert.NotNull(_quest.Category);
            Assert.Equal(validCategory, _quest.Category);
        }

        [Fact]
        public void SetValidCorrectAnswer()
        {

            //Arrange
            Question _quest = new Question();
            string validCorrectAnswert = "TestCorrectAnswer";

            //Act
            _quest.CorrectAnswer = validCorrectAnswert;

            //Assert
            Assert.NotNull(_quest.CorrectAnswer);
            Assert.Equal(validCorrectAnswert, _quest.CorrectAnswer);
        }

        [Fact]
        public void SetValidDamageValue()
        {

            //Arrange 
            Question _quest = new Question();
            int validDamageValue = 1;

            //Act
            _quest.DamageValue = validDamageValue;

            //Assert
            Assert.NotNull(_quest.DamageValue);
            Assert.Equal(validDamageValue, _quest.DamageValue);
        }
    }
}