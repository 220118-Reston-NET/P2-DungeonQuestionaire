using System.Data.SqlClient;
using ModelApi;

namespace DL
{
    public class EnemyRepository : IRepository<Enemy>
    {

        public Enemy Add(Enemy p_resource)
        {
            string sqlQuery = @"insert into enemy (enemyid, enemyname, enemyspriteimgurl, enemystartinghp, enemyattack)
            values (1, 'TestEnemyName', 'TestEnemySpriteURL', 1, 1)";

            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();

                SqlCommand com = new SqlCommand(sqlQuery, con);

            }
            return p_resource;
        }

        public List<Enemy> GetAll()
        {
            List<Enemy> listofAllEnemy = new List<Enemy>();
            string sqlQuery = @"";
            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();

                SqlCommand com = new SqlCommand(sqlQuery, con);

            }
            return listofAllEnemy;
        }

        public Enemy Update(Enemy p_resource)
        {
            string sqlQuery = @"";
            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();

                SqlCommand com = new SqlCommand(sqlQuery, con);

            }
            return p_resource;
        }

        public Enemy Delete(Enemy p_resource)
        {
            string sqlQuery = @"";
            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();

                SqlCommand com = new SqlCommand(sqlQuery, con);

            }
            return p_resource;
        }


    }
}