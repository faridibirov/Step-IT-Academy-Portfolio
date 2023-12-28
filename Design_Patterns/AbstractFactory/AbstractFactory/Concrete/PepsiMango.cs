using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete
{
    internal class PepsiMango : IFruit
    {
        public PepsiMango()
        {
            Console.WriteLine("Produce Pepsi Mango");
        }

        public string SpecialReceipt { get; set; }
    }
}