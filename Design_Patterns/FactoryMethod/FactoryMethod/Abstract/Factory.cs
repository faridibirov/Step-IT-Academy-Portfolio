using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Abstract
{
    abstract class Factory
    {
        public void Produce()
        {
            Console.WriteLine("Produce product");
        }
        public abstract IDepartment ProduceProduct();

    }
}
