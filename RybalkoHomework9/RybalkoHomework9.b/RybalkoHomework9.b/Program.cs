using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RybalkoHomework9
{
    internal class Program
    {
        private static void Main()
        {
            List<string> words = new List<string>();
            using (StreamReader SR = new StreamReader ("C:\\Users\\wylf1\\source\\repos\\RybalkoHomework9.b\\WWW.txt", true))
            {
                while (!SR.EndOfStream)
                {
                    string line = SR.ReadLine();
                    words.Add(line);
                    int chars = line.Count();
                    Console.WriteLine(chars);
                }
                string[] ordertomin = words.OrderBy(m => m.Length).ToArray();
                Console.WriteLine($"shortest line = '{ordertomin.First()}'");
                Console.WriteLine($"longest line = '{ordertomin.Last()}'");
                var var = (from v in words
                          where v.Contains("var")
                          select v).ToList();
                foreach( string v in var)
                {
                    Console.WriteLine(v);
                }
            }
            Console.ReadLine();
        }
    }
}