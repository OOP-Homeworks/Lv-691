using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RybalkoTask1
{
    internal class Program
    {
        private static void Main(string[] args) 
        {
            Execes1();
            Execes2();
            Execes3();
            Execes4();
        }
        private static void Execes1()
        {
            int a, b, sum, dif, mul;
            double div;
            Console.Write("Please enter a value a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter a value b=");
            b = Convert.ToInt32(Console.ReadLine());
            sum = a + b;
            dif = a - b;
            mul = a * b;
            div = (double)a / b;
            Console.WriteLine($"a={a};b={b};a+b={sum};a-b={dif};a*b={mul};a/b={div}");
        }
        private static void Execes2()
        {
            Console.WriteLine("How are you?");
            string answer = Console.ReadLine();
            Console.WriteLine($"You are {answer}");

        }
        private static void Execes3()
        {
            Console.WriteLine("Please enter first char");
            char firstchar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter second char");
            char secondchar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter third char");
            char thirdchar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"You enter {firstchar}, {secondchar}, {thirdchar}");

        }
        private static void Execes4()
        {
            Console.WriteLine("Please enter an integer");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter an integer");
            int b = Convert.ToInt32(Console.ReadLine());
            bool definition = a < 0;
            if (definition)
            {
                Console.WriteLine($"number {a} is negative");
            }
            else Console.WriteLine($"{a} positive number");
            definition = b < 0;
            if (definition)
            {
                Console.WriteLine($"number {b} is negative");
            }
            else Console.WriteLine($"{b} positive number");
        }
    }
}