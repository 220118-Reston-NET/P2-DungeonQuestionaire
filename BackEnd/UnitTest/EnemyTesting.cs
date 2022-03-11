using Models;
using Xunit;
namespace P2_DungeonQuestionnaire
{
    public class EnemyTesting
    {

        [Fact]
        public void SetValidEnemyID()
        {

            //Arrange
            Enemy _enemy = new Enemy();
            int validEnemyID = 1;

            //Act
            _enemy.EnemyID = validEnemyID;

            //Assert

            Assert.Equal(validEnemyID, _enemy.EnemyID);
        }

        [Fact]
        public void SetValidEnemyName()
        {

            //Arrange
            Enemy _enemy = new Enemy();
            string validEnemyName = "TestName";

            //Act
            _enemy.EnemyName = validEnemyName;

            //Assert
            Assert.NotNull(_enemy.EnemyName);
            Assert.Equal(validEnemyName, _enemy.EnemyName);
        }

        [Fact]
        public void SetValidEnemySpriteURL()
        {

            //Arrange
            Enemy _enemy = new Enemy();
            string validSpriteURL = "TestURL";

            //Act
            _enemy.EnemySpriteURL = validSpriteURL;

            //Assert
            Assert.NotNull(_enemy.EnemySpriteURL);
            Assert.Equal(validSpriteURL, _enemy.EnemySpriteURL);
        }

        [Fact]
        public void SetValidEnemyStartingHP()
        {

            //Arrange
            Enemy _enemy = new Enemy();
            int validEnemyStartingHP = 1;

            //Act
            _enemy.EnemyStartingHP = validEnemyStartingHP;

            //Assert

            Assert.Equal(validEnemyStartingHP, _enemy.EnemyStartingHP);
        }

        [Fact]
        public void SetValidEnemyAttack()
        {

            //Arrange
            Enemy _enemy = new Enemy();
            int validEnemyAttack = 1;

            //Act
            _enemy.EnemyAttack = validEnemyAttack;

            //Assert

            Assert.Equal(validEnemyAttack, _enemy.EnemyAttack);
        }

    }
}