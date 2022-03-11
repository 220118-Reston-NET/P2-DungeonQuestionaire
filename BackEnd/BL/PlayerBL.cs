using DL;
using Models;

namespace BL
{
    public class PlayerBL : IPlayerBL
    {

        private readonly IRepository<Player> _repo;

        public PlayerBL(IRepository<Player> p_repo)
        {
            _repo = p_repo;
        }


        public async Task<Player> AddPlayer(Player p_Player)
        {
            return await _repo.Add(p_Player);
        }


        public async Task<Player> DeletePlayer(Player p_Player)
        {
            return await _repo.Delete(p_Player);
        }


        public async Task<List<Player>> GetAllPlayers()
        {
            return await _repo.GetAll();
        }


        public async Task<Player> UpdatePlayer(Player p_Player)
        {
            return await _repo.Update(p_Player);
        }
    }
}