using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpMethod_Server
{
    public class Car
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public string Mark { get; set; }
        public int Year { get; set; }

        public Car(int id, string model, string mark, int year)
        {
            ID = id;
            Model = model;
            Mark = mark;
            Year = year;
        }

    public override string? ToString()
        {
            return $"{ID} - {Model} - {Mark} - {Year}";
        }
    }
}
