namespace ModelApi
{
    public class Questions
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

        private string _questions;
        public string Questions
        {
            get { return _questions; }
            set
            {
                if (value != "")
                {
                    _questions = value;
                }
                else
                {
                    Console.WriteLine("Questions cannot be empty");
                }
            }
        }

        private string _answers;
        public string Answers
        {
            get { return _answers; }
            set
            {
                if (value != "")
                {
                    _answers = value;
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