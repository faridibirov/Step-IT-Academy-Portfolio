namespace QuizApp
{
    public class Questions_DB
    {
        public Questions_DB()
        {
        }

        public List<Question> history = new List<Question> { };


        public List<Question> geography = new List<Question> { };

        [NonSerialized]
        public List<Question> mixed = new List<Question> { };


    }
}
