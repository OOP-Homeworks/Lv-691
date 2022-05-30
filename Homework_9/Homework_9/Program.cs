using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Homework_8;

namespace Homework_9
{
    public class Program
    {
        private static double i;

        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, -4, 56, 83, -9, 45, 78, -12, 3, 21 };
            foreach (int i in numbers)
            {
                if (i < 0)
                    Console.WriteLine(i);
            }
            foreach (int i in numbers)
            {
                if (i > 0)
                    Console.WriteLine(i);
            }
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Average());

            Console.WriteLine(numbers.Where(i => i < numbers.Average()).Max());

            IEnumerable<int> order = numbers.OrderBy(i => i);
            foreach (int i in order)
                Console.WriteLine(i);
            Console.ReadKey();


            //2
            List<Shape> shapes = new List<Shape>();
            for (var i = 0; i < 11; i++)
            {
                Console.WriteLine("Enter circle or square");
                string word = Console.ReadLine();
                if (word == "circle")
                {
                    Console.WriteLine("Write its name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Write its radius");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    shapes.Add(new Circle(name, radius));
                    i++;
                }
                else if (word == "square")
                {
                    Console.WriteLine("Write its name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Write its side");
                    double side = Convert.ToDouble(Console.ReadLine());
                    shapes.Add(new Square(name, side));
                    i++;
                }
                else
                {
                    Console.WriteLine("Your word is not correct.Write circle or square");
                    i--;
                }
                double maxPerimeter = shapes.Max(p => p.Perimeter());
                foreach (var shape in shapes.FindAll(p => p.Perimeter() == maxPerimeter))
                {
                    Console.WriteLine(value: $"Shape with the largest perimeter is {shape.Name()}. Perimeter is {shape.Perimeter()}");
                }
                shapes.Sort();
                foreach (var shape in shapes)
                {
                    Console.WriteLine($"Name of shape {shape.Name()}.Area is {shape.Area()}");
                }
                Console.ReadKey();

                var shapesRange = shapes.Where(j => j.Area() > 10 && j.Area() < 100);
                foreach (var j in shapesRange)
                {
                    Console.WriteLine("There are:" + j.Area());
                }


                var shapesContains = shapes.Where(j => j.Name().Contains("a"));
                foreach(var j in shapesContains)
                {
                    Console.WriteLine("There are:" + j.Name());
                }

                shapes.RemoveAll(j => j.Perimeter() < 5);
                foreach (var j in shapes)
                {
                    Console.WriteLine(j.Perimeter());
                }
                Console.ReadKey();


                //2B
                string[] file = File.ReadAllLines(Path.Join());

                    for (int f = 0; f< file.Length; f ++)
                {
                    Console.WriteLine($"Line {f} has {file[f].Length}");
                }


                string longLine = file.OrderByDescending(f => f.Length).First();
                Console.WriteLine(longLine);

                string shortLine = file.OrderByDescending(f => f.Length).Last();
                Console.WriteLine(shortLine);

                foreach (string g in file.ToList().FindAll(f => f.ToLower().Contains("var")))
                {
                    Console.WriteLine(g + "lines contains 'var'");
                }
                Console.ReadKey();
            }
        }
    }
}
