using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete
{
    internal class Bonaqua : ISoda
    {
        public Bonaqua()
        {
            Console.WriteLine("Produce Bonaqua");
        }

        public string SodaReceipt { get; set; }
    }
}