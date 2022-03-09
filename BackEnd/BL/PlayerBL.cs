using DL;
using Models;

namespace BL
{
    public class PlayerBL : IPlayerBL
    {

        private IRepository<Player> _repo;

        public PlayerBL(IRepository<Player> p_repo)
        {
            _repo = p_repo;
        }
        public Player AddPlayer(Player p_Player)
        {
            return _repo.Add(p_Player);
        }

        public Player DeletePlayer(Player p_Player)
        {
            return _repo.Delete(p_Player);
        }

        public List<Player> GetAllPlayer()
        {
            return _repo.GetAll();
        }

        public Player UpdatePlayer(Player p_Player)
        {
            return _repo.Update(p_Player);
        }
    }
}