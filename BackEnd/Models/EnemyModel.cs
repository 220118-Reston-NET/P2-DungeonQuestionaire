namespace Models
{
    public class Enemy
    {

        private int _enemyID;
        public int EnemyID
        {
            get { return _enemyID; }
            set
            {
                if (value > 0)
                {
                    _enemyID = value;
                }
                else
                {
                    Console.WriteLine("Enemy ID must be greater than zero");
                }
            }

        }

        private string _enemyName;
        public string EnemyName
        {
            get { return _enemyName; }
            set
            {
                if (value != "")
                {
                    _enemyName = value;
                }
                else
                {
                    Console.WriteLine("Enemy Name Cannot be Empty");

                }
            }

        }

        private string _enemySpriteURL;
        public string EnemySpriteURL
        {
            get { return _enemySpriteURL; }
            set
            {
                if (value != "")
                {
                    _enemySpriteURL = value;
                }
                else
                {
                    Console.WriteLine("Enemy Sprite URL cannot be empty");
                }
            }
        }

        private int _enemyStartingHP;
        public int EnemyStartingHP
        {
            get { return _enemyStartingHP; }
            set
            {
                if (value > 0)
                {
                    _enemyStartingHP = value;
                }
                else
                {
                    Console.WriteLine("Enemy Starting HP must be greater than zero");
                }
            }
        }

        private int _enemyAttack;
        public int EnemyAttack
        {
            get { return _enemyAttack; }
            set
            {
                if (value > 0)
                {
                    _enemyAttack = value;
                }
                else
                {
                    Console.WriteLine("Enemy Attack must be greater than zero");
                }
            }
        }





    }
}