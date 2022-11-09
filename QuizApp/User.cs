using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
   public  class User
    {

        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }

        public int Score { get; set; }

        public List<int> Records { get; set ; }

        public User() {}

        public User(string login, string password, DateTime birthday)
        {
            Login = login;
            Password = password;
            Birthday = birthday;
            Score = 0;
           Records = new List<int> { 0 };
        }


       
 
    }
}
