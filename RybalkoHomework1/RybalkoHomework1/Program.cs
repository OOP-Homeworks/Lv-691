using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RybalkoHomework1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Execes1();
            Execes2();
            Execes3();
        }
        private static void Execes1()
        {
            string a;
            int P, S;
            do
            {
                Console.WriteLine("Enter the integer variable a (side of the square)");
                Console.Write("a=");
                a = Console.ReadLine();
                if (Convert.ToDouble(a) % 1 > 0)
                {
                    Console.WriteLine("You did not enter an integer, please enter an integer!");
                }
                else break;
            } while (true);
                int b = Convert.ToInt32(a);
                S = b * b;
                P = b * 4;
                    Console.WriteLine($"P={P};S={S};");
                    Console.ReadLine();
            
        }
        private static void Execes2()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"How old are you,{name}?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{name} {age}");

        }
        private static void Execes3()
        {
            Console.Write("Read double number r (radius of a circle). r=");
            double r = Convert.ToDouble(Console.ReadLine());
            Double L = 2 * Math.PI * r;
            Double S = Math.PI * r * r;
            Double V = (4 / 3) * Math.PI * r * r * r;
            Console.WriteLine($"L={L} S={S} V={V} ");
        }
    }
    
}