using System.Data.SqlClient;
using ModelApi;

namespace DL
{
    public class EnemyRepository : IRepository<Enemy>
    {

        public Enemy Add(Enemy p_resource)
        {

            string sqlQuery = @"insert into Enemy 
                                values (@enemyname, @enemyspriteimgurl, @enemystartinghp, @enemyattack)";

            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();
                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@enemyname", p_resource.EnemyName);
                command.Parameters.AddWithValue("@enemyspriteimgurl", p_resource.EnemySpriteURL);
                command.Parameters.AddWithValue("@enemystartinghp", p_resource.EnemyStartingHP);
                command.Parameters.AddWithValue("@enemyattack", p_resource.EnemyAttack);
                command.ExecuteNonQuery();
            }
            return p_resource;
        }

        public List<Enemy> GetAll()
        {
            List<Enemy> listofAllEnemy = new List<Enemy>();
            string sqlQuery = @"select * from enemy";
            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    listofAllEnemy.Add(new Enemy(){
                            EnemyID = reader.GetInt32(0),
                            EnemyName = reader.GetString(1),
                            EnemySpriteURL = reader.GetString(2),
                            EnemyStartingHP = reader.GetInt32(3),
                            EnemyAttack= reader.GetInt32(4),
                    });
                }

            }
            return listofAllEnemy;
        }

        public Enemy Update(Enemy p_resource)
        {
            string sqlQuery = @"Update Enemy
                                Set EnemyName = @EnemyName, EnemySpriteImgUrl = @EnemySpriteImgurl, EnemyStartingHP = @EnemyStartingHP, EnemyAttack = @EnemyAttack
                                Where EnemyID = @EnemyId";
            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();
                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@EnemyId", p_resource.EnemyID);
                command.Parameters.AddWithValue("@EnemyName", p_resource.EnemyName);
                command.Parameters.AddWithValue("@EnemySpriteImgUrl", p_resource.EnemySpriteURL);
                command.Parameters.AddWithValue("@EnemyStartingHP", p_resource.EnemyStartingHP);
                command.Parameters.AddWithValue("@EnemyAttack", p_resource.EnemyAttack);
                command.ExecuteNonQuery();

            }
            return p_resource;
        }

        public Enemy Delete(Enemy p_resource)
        {
            string sqlQuery = @"Delete from Enemy
                                Where EnemyID = @EnemyID";
            using (SqlConnection con = new SqlConnection("STRING HERE"))
            {
                con.Open();
                SqlCommand com = new SqlCommand(sqlQuery, con);
                com.Parameters.AddWithValue("@EnemyID", p_resource.EnemyID);
                com.ExecuteNonQuery();
            }
            return p_resource;
        }


    }
}