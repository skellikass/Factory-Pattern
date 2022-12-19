using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Pants : IRetail
    {
        public double Price { get; set; } = 14.50;
        public string Color { get; set; } = "red";
        public void PrintDetails()
        {
            Console.WriteLine($"You have selected pants!  Your pants are {Color} and cost {Price,0:c}.");
        }
    }
}
