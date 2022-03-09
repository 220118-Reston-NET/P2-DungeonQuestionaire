namespace Models
{
    public class Question
    {

        private int _questionID;
        public int QuestionID
        {
            get { return _questionID; }
            set
            {
                if (value > 0)
                {
                    _questionID = value;
                }
                else
                {
                    Console.WriteLine("Question ID must be greater than zero");
                }
            }
        }


        private string _answer1;
        public string Answer1
        {
            get { return _answer1; }
            set
            {
                if (value != "")
                {
                    _answer1 = value;
                }
                else
                {
                    Console.WriteLine("Answers cannot be empty");
                }
            }
        }

        private string _answer2;
        public string Answer2
        {
            get { return _answer2; }
            set
            {
                if (value != "")
                {
                    _answer2 = value;
                }
                else
                {
                    Console.WriteLine("Answers cannot be empty");
                }
            }
        }
        private string _answer3;
        public string Answer3
        {
            get { return _answer3; }
            set
            {
                if (value != "")
                {
                    _answer3 = value;
                }
                else
                {
                    Console.WriteLine("Answers cannot be empty");
                }
            }
        }

        private string _answer4;
        public string Answer4
        {
            get { return _answer4; }
            set
            {
                if (value != "")
                {
                    _answer4 = value;
                }
                else
                {
                    Console.WriteLine("Answers cannot be empty");
                }
            }
        }

        private string _category;
        public string Category
        {
            get { return _category; }
            set
            {
                if (value != "")
                {
                    _category = value;
                }
                else
                {
                    Console.WriteLine("Category cannot be empty");
                }
            }
        }

        private string _correctAnswer;
        public string CorrectAnswer
        {
            get { return _correctAnswer; }
            set
            {
                if (value != "")
                {
                    _correctAnswer = value;
                }
                else
                {
                    Console.WriteLine("Answers cannot be empty");
                }
            }
        }

        private int _damageValue;
        public int DamageValue
        {
            get { return _damageValue; }
            set
            {
                if (value > 0)
                {
                    _damageValue = value;
                }
                else
                {
                    Console.WriteLine("Damage Value must be greater than zero");
                }
            }
        }






    }
}