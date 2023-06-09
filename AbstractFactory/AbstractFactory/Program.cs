using AbstractFactory.Abstract;
using AbstractFactory.Concrete;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISoftDrinksFactory factory = new ColaFactory();

            IClassic classiccola = factory.ProduceClassic();
            IZero zerocola = factory.ProduceZero();
            IFruit fanta = factory.ProduceFruit();
            ISoda bonaqua = factory.ProduceSoda(); 
            Console.WriteLine();
            
            
            factory = new PepsiFactory();

            IClassic pepsiclassic = factory.ProduceClassic();
            IZero pepsizero = factory.ProduceZero();
            IFruit pepsimango = factory.ProduceFruit();
            ISoda pepsisoda = factory.ProduceSoda();

        }
    }
}