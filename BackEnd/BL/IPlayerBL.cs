using Models;
namespace BL
{
    public interface IPlayerBL
    {

        Task<Player> AddPlayer(Player p_Player);

        Task<List<Player>> GetAllPlayers();

        Task<Player> UpdatePlayer(Player p_Player);

        Task<Player> DeletePlayer(Player p_Player);




    }
}