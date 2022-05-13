using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mala_tsk3
{
    internal class NamePriceDrinks
    {
        public enum NameOfDrinks
        {
            water = 15,
            tea = 25,
            coffee = 45,
            juice = 60
        }
        public void PrintPriceNameOfDrink(string input)
        {
            if (Enum.IsDefined(typeof(NameOfDrinks), input))
            {
                Console.WriteLine($"Your drink is: {input} and the price is {(int)Enum.Parse(typeof(NameOfDrinks), input)} UAH");
            }
            else
            {
                Console.WriteLine("Choose drink from list drinks");
            }

        }
    }
}
