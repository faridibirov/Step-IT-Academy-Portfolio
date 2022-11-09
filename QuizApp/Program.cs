using System.Xml.Serialization;

namespace QuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XmlSerializer Saveusers = new XmlSerializer(typeof(Users_DB));
                XmlSerializer Savequestions = new XmlSerializer(typeof(Questions_DB));
                Users_DB users = new Users_DB();
                Questions_DB questions = new Questions_DB();
                Menu menu = new Menu();
                User user = new User();

                menu.LoadQuestion(Savequestions, ref questions);
                menu.LoadUser(Saveusers, ref users);

                bool flaq = true;
                int choice;
                int choice2;

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
                            menu.UserSignIn(user, users, check, ref flaq);
                            break;
                        case 2:
                            Console.Clear();
                            menu.UserSignUp(user, users, check2, ref flaq);

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
                    menu.MainMenu();
                    choice2 = Int32.Parse(Console.ReadLine());

                    switch (choice2)
                    {
                        case 1:
                            Console.Clear();
                            menu.QuizMenu(questions, user, users);
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine($"\t\t\tPast Results:\n");
                            foreach (var usr in users.users)
                            {
                                if (usr.Login == user.Login)
                                {
                                    for (int i = 1; i < usr.Records.Count; i++)
                                    {
                                        Console.WriteLine($"\t\t\t{ usr.Login} -- Score: {usr.Records[i]}");
                                    }

                                }
                            }
                            break;

                        case 3:
                            Console.Clear();
                            users.users.Sort(
                                delegate (User p1, User p2)
                                {
                                    return p2.Records.Max().CompareTo(p1.Records.Max());
                                }

                                );
                            foreach (var score in users.users)
                            {

                                Console.WriteLine($"\t\t\tUser: {score.Login} -- Score:{score.Records.Max()}");
                            }
                            break;

                        case 4:
                            Console.Clear();
                            menu.SettingsMenu(users, user);
                            break;
                        case 5:
                            foreach (var i in users.users)
                            {
                                Console.WriteLine(i.Login);
                                Console.WriteLine(i.Password);
                                Console.WriteLine(i.Birthday);
                                Console.WriteLine();
                            }
                            break;
                        case 0:
                            menu.SaveQuestion(Savequestions, ref questions);
                            menu.SaveUser(Saveusers, ref users);
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

