using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete
{
    internal class Fanta : IFruit
    {
        public Fanta()
        {
            Console.WriteLine("Produce Fanta");
        }

        public string SpecialReceipt { get; set; }
    }
}