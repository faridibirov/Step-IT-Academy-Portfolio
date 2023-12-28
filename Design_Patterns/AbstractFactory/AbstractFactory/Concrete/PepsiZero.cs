using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete
{
    internal class PepsiZero : IZero
    {
        public PepsiZero()
        {
            Console.WriteLine("Produce Pepsi Zero");
        }

        public string PepsiReceipt { get; set; }
        public bool NoSugar { get; set; }
    }
}