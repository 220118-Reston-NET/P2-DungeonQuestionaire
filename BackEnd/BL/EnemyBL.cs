using DL;
using ModelApi;
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

        return
    }
}
