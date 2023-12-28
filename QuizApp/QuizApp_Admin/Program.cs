using QuizApp;
using System.Xml.Serialization;

namespace QuizApp_Admin
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XmlSerializer Saveusers = new XmlSerializer(typeof(Users_DB));
                XmlSerializer Savequestions = new XmlSerializer(typeof(Questions_DB));
                Questions_DB questions = new Questions_DB();
                AdminMenu admenu = new AdminMenu();
                Users_DB admins = new Users_DB();
                admenu.LoadUser(Saveusers, ref admins);
                admenu.LoadQuestion(Savequestions, ref questions);

                bool flaq = true;
                int choice;
                int choice2;
                Menu menu = new Menu();
                User admin = new User();
                int check = 0;
                int check2 = 0;
                do
                {
                    menu.LoginMenu();
                    choice = Int32.Parse(Console.ReadLine());
                    check = 0;
                    check2 = 0;

                    switch (choice)
                    {
                        case 1:
                            Console.Clear();
                            menu.UserSignIn(admin, admins, check, ref flaq);

                            break;
                        case 2:
                            Console.Clear();
                            menu.UserSignUp(admin, admins, check2, ref flaq);
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("\t\t\tWrong input");
                            Thread.Sleep(1000);
                            Console.Clear();
                            break;
                    }
                } while (flaq);

                do
                {
                    admenu.Menu();
                    choice2 = Int32.Parse(Console.ReadLine());
                    switch (choice2)
                    {
                        case 1:

                            Console.Clear();
                            admenu.Add(questions);
                            break;
                        case 2:
                            Console.Clear();
                            admenu.Remove(questions);
                            break;
                        case 3:
                            foreach (var item in questions.history)
                            {
                                Console.WriteLine(item);
                                Console.WriteLine();
                            }

                            foreach (var item in questions.geography)
                            {
                                Console.WriteLine(item);
                                Console.WriteLine();
                            }
                            break;
                        case 0:
                            admenu.SaveUser(Saveusers, ref admins);
                            admenu.SaveQuestion(Savequestions, ref questions);
                            Console.Clear();
                            Console.Write("\t\t\t\tClosing the application\n");
                            Console.Write("\t\t\t\t       .");
                            Thread.Sleep(1000);
                            Console.Write(".");
                            Thread.Sleep(1000);
                            Console.Write(".");
                            Thread.Sleep(1000);
                            Console.Write(".\n");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("\t\t\tWrong input");
                            Thread.Sleep(1000);
                            Console.Clear();
                            break;

                    }
                } while (choice2 != 0);

            }
            catch (FormatException)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"\t\t\t\t\tWrong input. Please try again.");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"\t\t\t\t{ex.Message}\n" +
                   $"\t\t\t\t\tPlease try again.");
                Console.ResetColor();

            }
        }


    }

}