namespace ModelApi
{
    public class Player
    {

        private int _playerID;
        public int PlayerID
        {
            get { return _playerID; }
            set
            {
                if (value > 0)
                {
                    _playerID = value;
                }
                else
                {
                    Console.WriteLine("Player ID must be greater than zero");
                }
            }
        }

        private string _PlayerName;
        public string PlayerName
        {
            get { return _PlayerName; }
            set
            {
                if (value != "")
                {
                    _PlayerName = value;
                }
                else
                {
                    Console.WriteLine("Player Name cannot be empty");
                }
            }
        }

        private string _spirteURL;
        public string SpriteURL
        {
            get { return _spirteU; }
            set
            {
                if (value != "")
                {
                    _spirteURL = value;
                }
                else
                {
                    Console.WriteLine("The Sprite URL cannot be empty");
                }

            }
        }

        private int _playerHP;
        public int PlayerHP
        {
            get { return _HP; }
            set
            {
                if (value > 0)
                {
                    _HP = value;
                }
                else
                {
                    Console.WriteLine("Player HP must be greater than zero");
                }
            }
        }

        private int _enemyCurrentFighting;
        public int EnemyCurrentFighting
        {
            get { return _enemyCurrentFighting; }
            set
            {
                if (value > 0)
                {
                    _enemyCurrentFighting = value;
                }
                else
                {
                    Console.WriteLine("value of the Current Enemy must be greater than zero");
                }
            }
        }

        private string _userEmail;
        public string UserEmail
        {
            get { return _userEmail; }
            set
            {
                if (value != "")
                {
                    _userEmail = value;
                }
                else
                {
                    Console.WriteLine("User Email cannot be empty");
                }
            }
        }

        private string _userPassword;
        public string UserPassword
        {
            get { return _userPassword; }
            set
            {
                if (value != "")
                {
                    _userPassword = value;
                }
                else
                {
                    Console.WriteLine("User Password cannot be empty");
                }
            }
        }








    }
}