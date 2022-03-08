using ModelApi;
namespace BL
{
    public interface IPlayerBL
    {

        Player AddPlayer(Player p_Player);

        List<Player> GetAllPlayer();

        Player UpdatePlayer(Player p_Player);

        Player DeletePlayer(Player p_Player);




    }
}