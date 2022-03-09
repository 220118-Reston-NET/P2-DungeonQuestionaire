using DL;
using Models;

namespace BL;




public class EnemyBL : IEnemyBL
{

    private IRepository<Enemy> _repo;
    public EnemyBL(IRepository<Enemy> p_repo)
    {

        _repo = p_repo;
    }

    public Enemy AddEnemy(Enemy p_enemy)
    {


        return _repo.Add(p_enemy);
    }

    public Enemy DeleteEnemy(Enemy p_enemy)
    {
        return _repo.Delete(p_enemy);
    }

    public List<Enemy> GetAllEnemy()
    {
        return _repo.GetAll();
    }

    public Enemy UpdateEnemy(Enemy p_enemy)
    {
        return _repo.Update(p_enemy);

    }
}
