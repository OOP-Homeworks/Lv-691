using System;
using System.Linq;
using System.Collections.Generic;

namespace Task9
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Write 10 numbers!");
            List<int> numbers = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                Console.Write($"Enter {i + 1} number: ");
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("----------------------");

            IEnumerable<int> onlyNegative = numbers.Where(i => i < 0);
            foreach(int i in onlyNegative)
                Console.WriteLine("Negative: " + i);
            Console.WriteLine("----------------------");

            IEnumerable<int> onlyPositive = numbers.Where(i => i >= 0);
            foreach (int i in onlyPositive)
                Console.WriteLine("Positive: " + i);
            Console.WriteLine("----------------------");

            Console.WriteLine("Max: "+ numbers.Max());
            Console.WriteLine("----------------------");
            Console.WriteLine("Average: " + numbers.Average());
            Console.WriteLine("----------------------");
            Console.WriteLine("Sum: " + numbers.Sum());
            Console.WriteLine("----------------------");
            Console.WriteLine("First smallest than average: " + numbers.Where(i => i < numbers.Average()).Max());
            Console.WriteLine("----------------------");

            Console.WriteLine("Sorted list: ");
            IEnumerable<int> sortedlist = numbers.OrderBy(i => i);
            foreach(int i in sortedlist)
                Console.WriteLine(i + "");
            Console.ReadKey();
        }
    }
}
