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
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Square("A1", 23));
            shapes.Add(new Square("A2", 5));
            shapes.Add(new Square("A3", 1));
            shapes.Add(new Circle("B1", 1));
            shapes.Add(new Circle("B2", 6));
            shapes.Add(new Circle("B3", 40));

            using (StreamWriter SW = new StreamWriter("C:\\Users\\wylf1\\source\\repos\\RybalkoHomework9\\New.txt", true))
            {
                var area = (from a in shapes
                           where a.area > 10 && a.area < 100
                           select a).ToList();
                foreach (var a in area)
                {
                    SW.WriteLine($"name- {a.Name}, area = {a.area}");
                }

                Regex regex = new Regex(@"[A]+");
                var names = (from n in shapes
                            where regex.Matches(n.Name).Count != 0
                            select n).ToList();
                foreach (var n in names)
                {
                    SW.WriteLine($"name- {n.Name}");
                }
            }
            var perimetr = (from p in shapes
                           where p.perimeter  < 5
                           select p).ToList();
            foreach(Shape c in perimetr)
            {
                shapes.Remove(c);
            }
            foreach(Shape c in shapes)
            {
                c.Print();
            }
            Console.ReadLine();
        }
    }
}
