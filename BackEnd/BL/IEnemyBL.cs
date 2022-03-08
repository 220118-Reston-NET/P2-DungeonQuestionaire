using ModelApi;
namespace BL
{
    public interface IEnemyBL
    {

        Enemy AddEnemy(Enemy p_enemy);

        List<Enemy> GetAllEnemy();

        Enemy UpdateEnemy(Enemy p_enemy);

        Enemy DeleteEnemy(Enemy p_enemy);




    }
}