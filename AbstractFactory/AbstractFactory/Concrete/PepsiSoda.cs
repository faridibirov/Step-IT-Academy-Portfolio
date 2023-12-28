using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete
{
    internal class PepsiSoda : ISoda
    {
        public PepsiSoda()
        {
            Console.WriteLine("Produce Pepsi Soda");
        }

        public string SodaReceipt { get; set; }
    }
}