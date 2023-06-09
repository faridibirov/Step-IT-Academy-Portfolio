using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete
{
    internal class ClassicPepsi : IClassic
    {
        public ClassicPepsi()
        {
            Console.WriteLine("Produce Classic Pepsi");
        }

        public string ClassicReceipt { get; set; }
    }
}