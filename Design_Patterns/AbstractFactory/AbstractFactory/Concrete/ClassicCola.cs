using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concrete
{
    internal class ClassicCola : IClassic
    {
        public ClassicCola()
        {
            Console.WriteLine("Produce Classic Cola");
        }

        public string ClassicReceipt { get; set; }
    }
}
