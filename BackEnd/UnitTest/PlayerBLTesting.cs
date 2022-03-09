using Moq;
using Xunit;
using Models;
using DL;
using BL;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace P2_DungeonQuestionnaire
{
    public class PlayerBLTesting
    {

        [Fact]
        public async Task Should_Add_Player()
        {
            //Assert
            Player _expectedPlayer = new Player()
            {
                PlayerID = 1,
                PlayerName = "TestName",
                SpriteURL = "TestURL",
                PlayerHP = 1,
                EnemyCurrentlyFighting = 1,
                UserEmail = "Test@email.com",
                UserPassword = "TestPassword",
                UserVictories = 1
            };

            Mock<IRepository<Player>> _mockRepo = new Mock<IRepository<Player>>();

            _mockRepo.Setup(repo => repo.Add(_expectedPlayer)).ReturnsAsync(_expectedPlayer);

            IPlayerBL _playBL = new PlayerBL(_mockRepo.Object);

            Player _actualPlayer = new Player();
            _actualPlayer = _expectedPlayer;

            //Act
            _actualPlayer = await _playBL.AddPlayer(_actualPlayer);

            //Assert
            Assert.Same(_expectedPlayer, _actualPlayer);
            Assert.Equal(_expectedPlayer.PlayerID, _actualPlayer.PlayerID);
            Assert.Equal(_expectedPlayer.PlayerName, _actualPlayer.PlayerName);
            Assert.Equal(_expectedPlayer.SpriteURL, _actualPlayer.SpriteURL);
            Assert.Equal(_expectedPlayer.PlayerHP, _actualPlayer.PlayerHP);
            Assert.Equal(_expectedPlayer.EnemyCurrentlyFighting, _actualPlayer.EnemyCurrentlyFighting);
            Assert.Equal(_expectedPlayer.UserEmail, _actualPlayer.UserEmail);
            Assert.Equal(_expectedPlayer.UserPassword, _actualPlayer.UserPassword);
            Assert.Equal(_expectedPlayer.UserVictories, _actualPlayer.UserVictories);
        }


        [Fact]
        public async Task Should_Get_All_Player()
        {
            //Assert
            List<Player> _expectedListOfPlayer = new List<Player>();

            Player _player = new Player()
            {
                PlayerID = 1,
                PlayerName = "TestName",
                SpriteURL = "TestURL",
                PlayerHP = 1,
                EnemyCurrentlyFighting = 1,
                UserEmail = "Test@email.com",
                UserPassword = "TestPassword",
                UserVictories = 1
            };

            _expectedListOfPlayer.Add(_player);

            Mock<IRepository<Player>> _mockRepo = new Mock<IRepository<Player>>();

            _mockRepo.Setup(repo => repo.GetAll()).ReturnsAsync(_expectedListOfPlayer);

            IPlayerBL _playBL = new PlayerBL(_mockRepo.Object);

            List<Player> _actualListOfPlayer = new List<Player>();
            _actualListOfPlayer = _expectedListOfPlayer;

            //Act
            _actualListOfPlayer = await _playBL.GetAllPlayer();

            //Assert
            Assert.Same(_expectedListOfPlayer, _actualListOfPlayer);
            Assert.Equal(_expectedListOfPlayer[0].PlayerID, _actualListOfPlayer[0].PlayerID);
            Assert.Equal(_expectedListOfPlayer[0].PlayerName, _actualListOfPlayer[0].PlayerName);
            Assert.Equal(_expectedListOfPlayer[0].SpriteURL, _actualListOfPlayer[0].SpriteURL);
            Assert.Equal(_expectedListOfPlayer[0].PlayerHP, _actualListOfPlayer[0].PlayerHP);
            Assert.Equal(_expectedListOfPlayer[0].EnemyCurrentlyFighting, _actualListOfPlayer[0].EnemyCurrentlyFighting);
            Assert.Equal(_expectedListOfPlayer[0].UserEmail, _actualListOfPlayer[0].UserEmail);
            Assert.Equal(_expectedListOfPlayer[0].UserPassword, _actualListOfPlayer[0].UserPassword);
            Assert.Equal(_expectedListOfPlayer[0].UserVictories, _actualListOfPlayer[0].UserVictories);
        }
    }
}