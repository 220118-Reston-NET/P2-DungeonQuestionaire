using Models;
namespace BL
{
    public interface IPlayerBL
    {

        Task<Player> AddPlayer(Player p_Player);

        Task<List<Player>> GetAllPlayers();

        Task UpdatePlayer(string SpriteImgurl, int PlayerHP, int EnemyCurrentlyFighting, string UserEmail, int UserVictories);

        Task<Player> DeletePlayer(Player p_Player);




    }
}