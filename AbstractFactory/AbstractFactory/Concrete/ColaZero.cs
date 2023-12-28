using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete
{
    internal class ColaZero : IZero
    {
        public ColaZero()
        {
            Console.WriteLine("Produce Cola-Zero");
        }

        public string PepsiReceipt { get; set; }
        public bool NoSugar { get; set; }
    }
}