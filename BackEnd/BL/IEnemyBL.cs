using Models;

namespace BL
{
    public interface IEnemyBL
    {

        Task<Enemy> AddEnemy(Enemy p_enemy);


        Task<List<Enemy>> GetAllEnemies();


        Task<Enemy> UpdateEnemy(Enemy p_enemy);

        Task<Enemy> DeleteEnemy(Enemy p_enemy);




    }
}