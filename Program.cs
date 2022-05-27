using System;
using System.Collections.Generic;

namespace hw10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> ls = new List<Triangle>(3);
            Random r = new Random();
            for (int i=0; i<3; i++)
            {
                Point a =  new Point(r.Next(-100, 100), r.Next(-100, 100));
                Point b = new Point(r.Next(-100, 100), r.Next(-100, 100));
                Point c = new Point(r.Next(-100, 100), r.Next(-100, 100));
                ls.Add(new Triangle(a, b, c));
            }
            try
            {
                Console.WriteLine($"First:\nArea: {Math.Round(ls[0].Area())} Perimeter: {Math.Round(ls[0].Perimeter())}");
                Console.WriteLine($"Second:\nArea: {Math.Round(ls[1].Area())} Perimeter: {Math.Round(ls[1].Perimeter())}");
                Console.WriteLine($"Third:\nArea: {Math.Round(ls[2].Area())} Perimeter: {Math.Round(ls[2].Perimeter())}");
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
