using System.Xml.Serialization;

namespace QuizApp
{


    public class Menu
    {

        public void LoginMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\n\t\t\t╔═════════════════════╗");
            Console.Write("\n\t\t\t║ ");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("Welcome to Quiz App");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" ║");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t\t\t╚═════════════════════╝");
            Console.ResetColor();
            Console.WriteLine("\t\t----------------------------------------------");
            Console.WriteLine("\t\t\t1 - Sign In");
            Console.WriteLine("\t\t\t2 - Sign Up");
            Console.WriteLine("\t\t----------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\t\tSelect command: ");
            Console.ResetColor();
        }

        public void MainMenu()
        {
            Console.WriteLine("\t\t==============================================================");
            Console.WriteLine("\t\t\t1 - Start new game");
            Console.WriteLine("\t\t\t2 - Past Results");
            Console.WriteLine("\t\t\t3 - Top-20");
            Console.WriteLine("\t\t\t4 - Settings");
            Console.WriteLine("\t\t\t0 - Exit");
            Console.WriteLine("\t\t==============================================================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\t\tSelect command: ");
            Console.ResetColor();
        }


        public void UserSignIn(User user, Users_DB users, int check, ref bool flaq)
        {
            Console.ResetColor();
            Console.Write("\t\t\tLogin: ");
            user.Login = Console.ReadLine();
            Console.Write("\t\t\tPassword: ");
            user.Password = Console.ReadLine();

            foreach (var item in users.users)
            {
                if (item.Login == user.Login && item.Password == user.Password)
                {
                    Console.WriteLine($"\n\t\t\tLogin succesfull! Welcome, {user.Login}");
                    flaq = false;
                    check++;
                }

            }
            if (check == 0)
            {
                Console.WriteLine("\n\t\t\tWrong username or password!");
                Thread.Sleep(1000);
                flaq = true;
            }

        }


        public void UserSignUp(User user, Users_DB users, int check2, ref bool flaq)
        {
            Console.WriteLine("\t\t\tEnter new user data");
            Console.ResetColor();
            Console.Write("\t\t\tLogin: ");
            user.Login = Console.ReadLine();
            Console.Write("\t\t\tPassword: ");
            user.Password = Console.ReadLine();
            Console.Write("\t\t\tEnter birthdate (yyyy-mm-dd): ");
            user.Birthday = DateTime.Parse(Console.ReadLine());
            user.Score = 0;
            user.Records = new List<int> { 0 };
            foreach (var item in users.users)
            {
                if (user.Login == item.Login)
                {
                    Console.WriteLine($"\n\t\t\t User {user.Login}  already exists, Please try again. ");
                    Thread.Sleep(1500);
                    flaq = true;
                    check2++;
                }
            }
            if (check2 == 0)
            {
                Console.WriteLine($"\n\t\t\tNew user succefully crated! Please sign in.");
                Thread.Sleep(1500);
                users.users.Add(new User() { Login = user.Login, Password = user.Password, Birthday = user.Birthday, Records = user.Records, Score = user.Score });
                flaq = true;

            };
        }


        public void QuizMenu(Questions_DB questions, User user, Users_DB users)
        {
            questions.mixed.Clear();
            for (int i = 0; i < 5; i++)
            {
                Random random = new Random();
                questions.mixed.Add(questions.history[random.Next(0, 10)]);
                questions.mixed.Add(questions.geography[random.Next(0, 10)]);

            }
            Console.Clear();
            Console.WriteLine("\t\t----------------------------------------------");
            Console.WriteLine("\t\t\t1 - History");
            Console.WriteLine("\t\t\t2 - Geography");
            Console.WriteLine("\t\t\t3 - Mixed");
            Console.WriteLine("\t\t----------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\t\tSelect topic: ");
            Console.ResetColor();
            var qui = questions.geography;
            int quizm = Int32.Parse(Console.ReadLine());
            if (quizm == 1) { qui = questions.history; }
            if (quizm == 2) { qui = questions.geography; }
            if (quizm == 3) { qui = questions.mixed; }
            int qn = 1;
            foreach (var quest in qui)
            {
                Console.WriteLine($"\n{qn}. {quest}\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Enter answer: ");
                Console.ResetColor();
                string otvet = Console.ReadLine();
                if (otvet.ToUpper() == "A" && quest.Answers[0].IsCorrect)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\t\t\tCorrect!");
                    Thread.Sleep(500);
                    Console.ResetColor();
                    user.Score++;
                }
                else if (otvet.ToUpper() == "B" && quest.Answers[1].IsCorrect)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\t\t\tCorrect!");
                    Thread.Sleep(500);
                    Console.ResetColor();
                    user.Score++;
                }
                else if (otvet.ToUpper() == "C" && quest.Answers[2].IsCorrect)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\t\t\tCorrect!");
                    Thread.Sleep(500);
                    Console.ResetColor(); ;
                    user.Score++;
                }
                else if (otvet.ToUpper() == "D" && quest.Answers[3].IsCorrect)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\t\t\tCorrect!");
                    Thread.Sleep(500);
                    Console.ResetColor();
                    user.Score++;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\t\t\tNot Correct!");
                    Thread.Sleep(500);
                    Console.ResetColor();
                }
                qn++;
                Console.Clear();
            }

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"\n\t\t\tYour Score:{user.Score}");
            Console.ResetColor();

            foreach (var item in users.users)
            {
                if (item.Login == user.Login)
                {
                    item.Score = user.Score;
                    item.Records.Add(user.Score);

                }
            }
            user.Score = 0;
        }

        public void SaveUser(XmlSerializer Saveusers, ref Users_DB users)
        {
            using (Stream fStream = File.Create("../../../../users.xml"))
            {
                Saveusers.Serialize(fStream, users);
            }

        }

        public void SaveQuestion(XmlSerializer Savequestions, ref Questions_DB questions)
        {
            using (Stream fStream =File.Create("../../../../questions.xml"))
            {
                Savequestions.Serialize(fStream, questions);
            }

        }


        public void LoadUser(XmlSerializer Saveusers, ref Users_DB users)
        {
            using (Stream fStream = File.OpenRead("../../../../users.xml"))
            {
                users = (Users_DB)Saveusers.Deserialize(fStream);
            }

        }

        public void LoadQuestion(XmlSerializer Savequestions, ref Questions_DB questions)
        {
            using (Stream fStream = File.OpenRead("../../../../questions.xml"))
            {
                questions = (Questions_DB)Savequestions.Deserialize(fStream);
            }

        }



        public void SettingsMenu(Users_DB users, User user)
        {
            Console.Clear();
            Console.WriteLine("\t\t----------------------------------------------");
            Console.WriteLine("\t\t\t1 - Change user birthdate");
            Console.WriteLine("\t\t\t2 - Change user password");
            Console.WriteLine("\t\t----------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\t\tSelect command: ");
            Console.ResetColor();
            int setting = Int32.Parse(Console.ReadLine());
            DateTime newbirthday;
            string newpassword;
            string oldpassword;
            if (setting == 1)
            {
                foreach (var item in users.users)
                {
                    if (item.Login == user.Login)
                    {
                        Console.Write("\t\t\tEnter new birthday (yyyy-mm-dd): ");
                        newbirthday = DateTime.Parse(Console.ReadLine());
                        item.Birthday = newbirthday;

                    }
                }
                Console.WriteLine("\t\t\tBirthday was succesfully changed.");
            }

            if (setting == 2)
            {
                foreach (var item in users.users)
                {
                    if (item.Login == user.Login)
                    {
                        Console.Write("\t\t\tEnter old password: ");
                        oldpassword = Console.ReadLine();
                        if (oldpassword == item.Password)
                        {
                            Console.Write("\t\t\tEnter new password: ");
                            newpassword = Console.ReadLine();
                            item.Password = newpassword;
                            Console.WriteLine("\t\t\tPassword was succesfully changed.");
                        }
                        else Console.WriteLine("\t\t\tOld password is wrong.");

                    }
                }
               ;
            }
        }

    }
}
