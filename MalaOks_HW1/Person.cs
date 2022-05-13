using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalaOks_HW1
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Print()
        {
            Console.WriteLine($"Your name is: {Name} and your age is: {Age}");
        }
    }
}
