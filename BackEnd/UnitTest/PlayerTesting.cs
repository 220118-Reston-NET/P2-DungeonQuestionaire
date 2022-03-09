using Xunit;
using Models;
namespace P2_DungeonQuestionnaire
{
    public class PlayerTesting
    {

        [Fact]
        public void SetValidPlayerID()
        {

            //Arrange
            Player _player = new Player();
            int validPlayerID = 1;

            //Act
            _player.PlayerID = validPlayerID;

            //Assert
            Assert.NotNull(_player.PlayerID);
            Assert.Equal(validPlayerID, _player.PlayerID);
        }

        public void SetValidPlayerName()
        {

            //Arrange
            Player _player = new Player();
            string validPlayerName = "TestName";

            //Act
            _player.PlayerName = validPlayerName;

            //Assert
            Assert.NotNull(_player.PlayerName);
            Assert.Equal(validPlayerName, _player.PlayerName);
        }

        public void SetValidSpriteURL()
        {

            //Arrange
            Player _player = new Player();
            string validSpriteURL = "TestURL";

            //ACT
            _player.SpriteURL = validSpriteURL;

            //Assert
            Assert.NotNull(_player.SpriteURL);
            Assert.Equal(validSpriteURL, _player.SpriteURL);
        }

        public void SetValidPlayerHP()
        {

            //Arrange
            Player _player = new Player();
            int validPlayerHP = 1;

            //Act
            _player.PlayerHP = validPlayerHP;

            //Assert
            Assert.NotNull(_player.PlayerHP);
            Assert.Equal(validPlayerHP, _player.PlayerHP);
        }

        public void SetValidEnemyCurrentFighting()
        {

            //Arrange
            Player _player = new Player();
            int validEnemyCurrentFighting = 1;

            //Act
            _player.EnemyCurrentlyFighting = validEnemyCurrentFighting;

            //Assert
            Assert.NotNull(_player.EnemyCurrentlyFighting);
            Assert.Equal(validEnemyCurrentFighting, _player.EnemyCurrentlyFighting);
        }

        public void SetValidUserName()
        {

            //Arrange 
            Player _player = new Player();
            string validUserEmail = "TestEmail";

            //Act
            _player.UserEmail = validUserEmail;

            //Assert
            Assert.NotNull(_player.UserEmail);
            Assert.Equal(validUserEmail, _player.UserEmail);

        }

        public void SetValidPassword()
        {

            //Arrange
            Player _player = new Player();
            string validUserPassword = "TestPassword";

            //Act
            _player.UserPassword = validUserPassword;

            //Assert
            Assert.NotNull(_player.UserPassword);
            Assert.Equal(validUserPassword, _player.UserPassword);
        }


    }


}