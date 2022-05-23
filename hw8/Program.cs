using System;
using System.Collections.Generic;
using System.Linq;

namespace hw8_osypov
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            for (var i = 0; i < 10; i++)
            {
                Console.Write("Enter 'circle' or 'square': ");
                string word = Convert.ToString(Console.ReadLine());
                if (word == "circle")
                {
                    Console.WriteLine("now write name and its radius:");
                    string name = Console.ReadLine();
                    double r = System.Convert.ToDouble(Console.ReadLine());
                    shapes.Add(new Circle(name, r));
                    i++;
                }
                else if (word == "square")
                {
                    Console.WriteLine("now write name and its side:");
                    string name = Console.ReadLine();
                    double s = System.Convert.ToDouble(Console.ReadLine());
                    shapes.Add(new Square(name, s));
                    i++;
                }
                else
                {
                    Console.WriteLine("Entered word doesn't match 'circle' or 'square'");
                    i--;
                }
            }
            double maxPerimeter = shapes.Max(p => p.Perimeter());
            foreach (var shape in shapes.FindAll(p => p.Perimeter() == maxPerimeter))
            {
                Console.WriteLine($"Shape with a maximum Perimeter is {shape.Name}. Perimeter: {shape.Perimeter():F2}.");
            }
            shapes.Sort();
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Name of shape {shape.Name}. Area: {shape.Area():F2}.");
            }
            Console.ReadKey();
        }
    }
}
