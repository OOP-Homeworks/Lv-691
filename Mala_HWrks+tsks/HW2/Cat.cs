using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Cat
    {
        public enum CatFood
        {
            fish = 80,
            meat = 100,            
            dryfood = 90,
            wetfood = 95,
            chicken = 60
        }

        public int SatietyLevel { get; set; }


        public void SomethingToEat(string input)
        {            
            if (Enum.IsDefined(typeof(CatFood), input))
            {
                SatietyLevel = (int)Enum.Parse(typeof(CatFood), input);
                Console.WriteLine($"The cat ate {input} and the satiety level is {SatietyLevel}%");
            }
            else
            {
                Console.WriteLine("Food unsuitable for feeding a cat");
            }

        }
    }
}
