

namespace Ware_House
{
   public  class User
    {

        public string Login { get; set; }
        public string Password { get; set; }
        
        public string Name { get; set; }    

        public string Surname { get; set; }


        public List<Client> clients = new List<Client>();

        public List<Order> orders = new List<Order> ();

        public User() {}

        public User(string login, string password, string name, string surname)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
        }


       
 
    }
}
