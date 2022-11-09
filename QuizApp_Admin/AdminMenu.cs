using QuizApp;
namespace QuizApp_Admin
{
    public class AdminMenu : Menu
    {


        public void Menu()
        {
            Console.WriteLine("\t\t==============================================================");
            Console.WriteLine("\t\t\t1 - Add Quiz");
            Console.WriteLine("\t\t\t2 - Remove Quiz");
            Console.WriteLine("\t\t\t0 - Exit");
            Console.WriteLine("\t\t==============================================================");
            Console.Write("\t\tSelect command: ");
        }


        public void Add(Questions_DB questions)
        {
            var qui1 = questions.history;
            Console.WriteLine("\t\t----------------------------------------------");
            Console.WriteLine("\t\t\t1 - History");
            Console.WriteLine("\t\t\t2 - Geography");
            Console.WriteLine("\t\t----------------------------------------------");
            Console.Write("\t\tSelect topic: ");
           int subject1 = Int32.Parse(Console.ReadLine());
            if (subject1 == 1) qui1 = questions.history;
            if (subject1 == 2) qui1 = questions.geography;
            Console.Clear();
            Console.Write("\t\t\tEnter Question: ");
            string question = Console.ReadLine();
            Console.Write("\t\t\tEnter Answer 1: ");
            string answer1 = Console.ReadLine();
            Console.Write("\t\t\tIs it correct answer? Enter true/false: ");
            bool iscorrect1 = bool.Parse(Console.ReadLine());

            Console.Write("\t\t\tEnter Answer 2: ");
            string answer2 = Console.ReadLine();
            Console.Write("\t\t\tIs it correct answer? Enter true/false: ");
            bool iscorrect2 = bool.Parse(Console.ReadLine());

            Console.Write("\t\t\tEnter Answer 3: ");
            string answer3 = Console.ReadLine();
            Console.Write("\t\t\tIs it correct answer? Enter true/false: ");
            bool iscorrect3 = bool.Parse(Console.ReadLine());

            Console.Write("\t\t\tEnter Answer 4: ");
            string answer4 = Console.ReadLine();
            Console.Write("\t\t\tIs it correct answer? Enter true/false: ");
            bool iscorrect4 = bool.Parse(Console.ReadLine());


            qui1.Add(

                new Question()
                {
                    Text = question,
                    Answers = new List<Answer>()
                {
                                         new Answer() { Text = answer1, IsCorrect=iscorrect1 },
                                         new Answer() { Text = answer2, IsCorrect=iscorrect2 },
                                         new Answer() { Text = answer3, IsCorrect=iscorrect3 },
                                         new Answer() { Text = answer4, IsCorrect=iscorrect4 },
                }
                });
            Console.WriteLine("\t\t\tQuestion added succesfully!");
            Thread.Sleep(1000);
            Console.Clear();
        }


        public void Remove (Questions_DB questions)
        {
            var qui1 = questions.history;
            Console.WriteLine("\t\t----------------------------------------------");
            Console.WriteLine("\t\t\t1 - History");
            Console.WriteLine("\t\t\t2 - Geography");
            Console.WriteLine("\t\t----------------------------------------------");
            Console.Write("\t\tSelect topic: ");
            int subject2 = Int32.Parse(Console.ReadLine());
            if (subject2 == 1) qui1 = questions.history;
            if (subject2 == 2) qui1 = questions.geography;
            int i = 0;

            foreach (var item in qui1)
            {
                Console.WriteLine($"{i + 1}. {item}"); ;
                Console.WriteLine();
                i++;
            }

            Console.WriteLine("\t\t\tChoose question you want to delete:");
            int number = Int32.Parse(Console.ReadLine());
            try
            {
                qui1.RemoveAt(number - 1);
                Console.WriteLine("\t\t\tQuestion was deleted successfully!");
                Thread.Sleep(1000);
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("\t\t\tWrong question number.");
                Thread.Sleep(1000);
            }
            Console.Clear();
        }
        

    }
}
