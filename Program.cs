using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace hw9
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"C:\Users\Professional\source\repos\hw9\hw9\Text.txt", System.Text.Encoding.Default);
            string line;
            List<string> array = new List<string>();
            while((line=reader.ReadLine())!=null)
            { 
                array.Add(line);
            }
            reader.Close();

            int i = 1;
            string min = array[0];
            string max = array[0];
            foreach(string el in array)
            {
                if (el.Length > max.Length) max = el;
                if (el.Length < min.Length) min = el;
                Console.WriteLine($"In {i++} line is {el.Count()} symbols");
            }
            Console.WriteLine();

            Console.WriteLine($"The largest line: {max}");
            Console.WriteLine($"The smalest line: {min}\n");

            var results = from c in array
               where c.Contains("now")
               select c;

            foreach (var el in results)
            {
                Console.WriteLine(el);
            }

        }

    }
}

