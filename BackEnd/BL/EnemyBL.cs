using DL;
using Models;

namespace BL;




public class EnemyBL : IEnemyBL
{

    private readonly IRepository<Enemy> _repo;
    public EnemyBL(IRepository<Enemy> p_repo)
    {

        _repo = p_repo;
    }

    public async Task<Enemy> AddEnemy(Enemy p_enemy)
    {


        return await _repo.Add(p_enemy);
    }

    public async Task<Enemy> DeleteEnemy(Enemy p_enemy)
    {
        return await _repo.Delete(p_enemy);
    }

    public async Task<List<Enemy>> GetAllEnemies()
    {
        return await _repo.GetAll();
    }

    public async Task<Enemy> UpdateEnemy(Enemy p_enemy)
    {
        return await _repo.Update(p_enemy);

    }
}
