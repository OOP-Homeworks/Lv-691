using System;
using System.Collections.Generic;

namespace MalaOks_HW8
{
    internal class Program
    {

        private static void EnterShape(List<Shape> shp)
        {
            int amount = 5;
            string name = String.Empty;
            double lenth = 0;
            for (int i = 0; i < amount; i++)
            {
            a:
                try
                {
                    Console.WriteLine("Please enter shape, for circle 'c' or square 's'");
                    name = Console.ReadLine().Substring(0, 1);
                    if (name != "c" & name != "s")
                    {
                        Console.WriteLine("You can only choose circle or square");
                        goto a;
                    }
                    Console.WriteLine("Enter the side length of a square or radius for a circle");
                    lenth = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong format");
                    goto a;
                }
                switch (name)
                {
                    case "c":
                        {
                            shp.Add(new Circle(lenth, nameof(Circle)));
                            break;
                        }
                    case "s":
                        {
                            shp.Add(new Square(lenth, nameof(Square)));
                            break;
                        }
                }
            }
        }


        static void Main(string[] args)
        {
            List<Shape> shapes = new();
            EnterShape(shapes);
            foreach (var item in shapes)
            {
                item.GetArea();
                item.GetPerimeter();
                item.Print();
            }
            double max = 0;
            string nm = String.Empty;
            foreach (var item in shapes)
            {
                if (item.Perimeter > max)
                {
                    max = item.Perimeter;
                    nm = item.Name;
                }

            }
            Console.WriteLine($"\nShape: {nm} with max perimeter: {max}");
            //просто пробую, разницы не увидела, что лучше использовать? \n или Environment.NewLine
            Console.WriteLine($"{Environment.NewLine}Sort shapes");
            shapes.Sort();
            foreach (var item in shapes)
            {
                item.Print();
            }


        }
    }
}
