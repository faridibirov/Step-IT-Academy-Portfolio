using FactoryMethod.Abstract;
using FactoryMethod.Specific;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Specific
{
    internal class Meat : Factory
    {
        public override IDepartment ProduceProduct() => new Sausage();
    }
}
