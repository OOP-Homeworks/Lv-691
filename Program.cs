using System;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1\n1)");
            int a, b;
            Console.Write("a = ");
            a = System.Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sum {a+b}");
            Console.WriteLine($"Dif {a - b}");
            Console.WriteLine($"Mul {a * b}");
            Console.WriteLine($"Div {a / b}");

            Console.WriteLine("\n2)");
            Console.WriteLine("How are you?");
            string answer = Console.ReadLine();
            Console.Write($"You are {answer}\n");

            Console.WriteLine("\n3)");
            Console.WriteLine("Input char:");
            char x,y,z;
            x= System.Convert.ToChar(Console.ReadLine());
            y = System.Convert.ToChar(Console.ReadLine());
            z = System.Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"You enter: {x}, {y}, {z}");

            Console.WriteLine("\n4)");

            static bool check(int a, int b)
            {
                bool result=false;
                if (a > 0 && b > 0)
                {
                    result = true;
                }
                return result;
            }
            int s, m;
            Console.Write("first integer = ");
            s = System.Convert.ToInt32(Console.ReadLine());
            Console.Write("second integer = ");
            m = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(check(s, m) ? "they are both positive" : "one or two are not positive\n");

            Console.WriteLine("Homework 1\n1)");
            int side;
            Console.Write("enter side of square  ");
            side = System.Convert.ToInt32(Console.ReadLine());
            int area = side * side;
            int per = 4 * side;
            Console.WriteLine($"Area: {area}  Perimeter: {per}");

            Console.WriteLine("\n2)");
            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine($"How old are you, {name}?");
            int age = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your name is {name} and you are {age} years old");

            Console.WriteLine("\n3)");
            double radius;
            Console.Write("enter the radius of circle  ");
            radius = System.Convert.ToInt32(Console.ReadLine());
            double L = 2*3.14*radius;
            double S = 3.14*radius*radius;
            double V = 4 / 3 * 3.14 * radius * radius * radius;
            Console.WriteLine($"Area: {S}  Length: {L}  Volume: {V}");

        }
    }
}
