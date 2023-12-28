using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Abstract
{
    internal interface ISoftDrinksFactory
    {
        IClassic ProduceClassic();
        IZero ProduceZero();
        IFruit ProduceFruit();

        ISoda ProduceSoda();
    }
}
