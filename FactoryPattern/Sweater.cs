using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Sweater : IRetail
    {
        public double Price { get; set; } = 19.99;
        public string Color { get; set; } = "green";
        public void PrintDetails()
        {
            Console.WriteLine($"You have selected a sweater!  Your sweater is {Color} and costs {Price,0:c}.");
        }
    }
}
