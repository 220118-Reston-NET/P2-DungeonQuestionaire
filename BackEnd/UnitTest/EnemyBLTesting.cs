using Moq;
using Xunit;
using Models;
using DL;
using BL;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace P2_DungeonQuestionnaire
{
    public class EnemyBLTesting
    {

        [Fact]
        public async Task Should_Add_Enemy()
        {
            //Assert
            Enemy _expectedEnemy = new Enemy()
            {
                EnemyID = 1,
                EnemyName = "TestName",
                EnemySpriteURL = "TestURL",
                EnemyStartingHP = 1,
                EnemyAttack = 1,

            };

            Mock<IRepository<Enemy>> _mockRepo = new Mock<IRepository<Enemy>>();

            _mockRepo.Setup(repo => repo.Add(_expectedEnemy)).ReturnsAsync(_expectedEnemy);

            IEnemyBL _EnemyBL = new EnemyBL(_mockRepo.Object);

            Enemy _actualEnemy = new Enemy();
            _actualEnemy = _expectedEnemy;

            //Act
            _actualEnemy = await _EnemyBL.AddEnemy(_actualEnemy);

            //Assert
            Assert.Same(_expectedEnemy, _actualEnemy);
            Assert.Equal(_expectedEnemy.EnemyID, _actualEnemy.EnemyID);
            Assert.Equal(_expectedEnemy.EnemyName, _actualEnemy.EnemyName);
            Assert.Equal(_expectedEnemy.EnemySpriteURL, _actualEnemy.EnemySpriteURL);
            Assert.Equal(_expectedEnemy.EnemyStartingHP, _actualEnemy.EnemyStartingHP);
            Assert.Equal(_expectedEnemy.EnemyAttack, _actualEnemy.EnemyAttack);

        }


        [Fact]
        public async Task Should_Get_All_Enemy()
        {
            //Assert
            List<Enemy> _expectedListOfEnemy = new List<Enemy>();

            Enemy _Enemy = new Enemy()
            {
                EnemyID = 1,
                EnemyName = "TestName",
                EnemySpriteURL = "TestURL",
                EnemyStartingHP = 1,
                EnemyAttack = 1,

            };

            _expectedListOfEnemy.Add(_Enemy);

            Mock<IRepository<Enemy>> _mockRepo = new Mock<IRepository<Enemy>>();

            _mockRepo.Setup(repo => repo.GetAll()).ReturnsAsync(_expectedListOfEnemy);

            IEnemyBL _EnemyBL = new EnemyBL(_mockRepo.Object);

            List<Enemy> _actualListOfEnemy = new List<Enemy>();
            _actualListOfEnemy = _expectedListOfEnemy;

            //Act
            _actualListOfEnemy = await _EnemyBL.GetAllEnemies();

            //Assert
            Assert.Same(_expectedListOfEnemy, _actualListOfEnemy);
            Assert.Equal(_expectedListOfEnemy[0].EnemyID, _actualListOfEnemy[0].EnemyID);
            Assert.Equal(_expectedListOfEnemy[0].EnemyName, _actualListOfEnemy[0].EnemyName);
            Assert.Equal(_expectedListOfEnemy[0].EnemySpriteURL, _actualListOfEnemy[0].EnemySpriteURL);
            Assert.Equal(_expectedListOfEnemy[0].EnemyStartingHP, _actualListOfEnemy[0].EnemyStartingHP);
            Assert.Equal(_expectedListOfEnemy[0].EnemyAttack, _actualListOfEnemy[0].EnemyAttack);

        }
    }
}