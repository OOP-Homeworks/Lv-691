using System;
using System.Collections.Generic;

namespace hw8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> data = new List<Shape>(5);
            Console.WriteLine("Enter 5 different shapes.");
            int k = 0;
            do
            {
                Console.WriteLine("Enter C for circle and S for square:");
                char mark = System.Convert.ToChar(Console.ReadLine());
                if (mark == 'C')
                {
                    Console.WriteLine("now write name and its radius:");
                    string temp_name = Console.ReadLine();
                    double temp_r = System.Convert.ToDouble(Console.ReadLine());
                    data.Add( new Circle(temp_name, temp_r));
                    k++;
                }
                else if(mark=='S')
                {
                    Console.WriteLine("now write name and its side:");
                    string temp_name = Console.ReadLine();
                    double temp_s = System.Convert.ToDouble(Console.ReadLine());
                    data.Add( new Square(temp_name, temp_s));
                    k++;
                }
                else
                {
                    Console.WriteLine("Wrong leter, try again:)");
                }
            }
            while (k < 5);

            Console.WriteLine("Your Shapes:");
            for(var i=0; i<k; i++)
            {
                Console.WriteLine($"{data[i].Name} \tArea: {Math.Round(data[i].Area())} \tPerimeter {Math.Round(data[i].Perimeter())} ");
            }

            Shape maximum=data[0];
            for (var i = 1; i < k; i++)
            {
                if (data[i].Perimeter() > maximum.Perimeter()) maximum = data[i];
            }
            Console.WriteLine($"Shape with largest perimeter is {maximum.Name} and it is {Math.Round(maximum.Perimeter())}");

            data.Sort();
            Console.WriteLine("Sorted Shapes:");
            for (var i = 0; i < k; i++)
            {
                Console.WriteLine($"{data[i].Name} \tArea: {Math.Round(data[i].Area())} \tPerimeter {Math.Round(data[i].Perimeter())} ");
            }
        }
    }
}
