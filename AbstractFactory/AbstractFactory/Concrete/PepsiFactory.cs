using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concrete
{
    internal class PepsiFactory : ISoftDrinksFactory
    {
        public IClassic ProduceClassic() => new ClassicPepsi();


        public IFruit ProduceFruit() => new PepsiMango();


        public ISoda ProduceSoda() => new PepsiSoda();
    

        public IZero ProduceZero() => new PepsiZero();
      
    }
}
