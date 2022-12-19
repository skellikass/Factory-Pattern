using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ClothingFactory
    {
        public static IRetail GetCLothing(string clothingItem)
        {
            switch (clothingItem.ToLower()) 
            {
                case "sweater":
                    return new Sweater();
                case "pants":
                    return new Pants();
                default:
                    return new Sweater();
            }
        }
    }
}
