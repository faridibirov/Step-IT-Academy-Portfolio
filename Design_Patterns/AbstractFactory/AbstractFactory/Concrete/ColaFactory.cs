using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concrete
{
    internal class ColaFactory : ISoftDrinksFactory
    {


        public IClassic ProduceClassic() => new ClassicCola();

        public IFruit ProduceFruit() => new Fanta();


        public ISoda ProduceSoda() => new Bonaqua();

        public IZero ProduceZero() => new ColaZero();
     
    }
}
