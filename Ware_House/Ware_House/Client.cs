using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ware_House
{
    public class Client
    {

        public string Name { get; set; }
        public string Surname { get; set; } 

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }


        public Client() { }

        public Client(string name, string surname, string email, string phone, string address)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            Address = address;
        }

        public override string? ToString()
        {
            return $"{Name} {Surname} {Email} {Phone} {Address}";
        }
    }
}
