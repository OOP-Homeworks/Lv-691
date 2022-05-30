using System;
using System.Collections.Generic;

namespace osypov_hw10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();
            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                Point a = new Point(r.Next(-10, 10), r.Next(-10, 10));
                Point b = new Point(r.Next(-10, 10), r.Next(-10, 10));
                Point c = new Point(r.Next(-10, 10), r.Next(-10, 10));
                triangles.Add(new Triangle(a, b, c));
            }
            try
            {
                Console.WriteLine("First: Square: " + Math.Round(triangles[0].Square()) +
                    " Perimeter: " + Math.Round(triangles[0].Perimeter()));
                Console.WriteLine("Second: Square: " + Math.Round(triangles[1].Square()) +
                    " Perimeter: " + Math.Round(triangles[1].Perimeter()));
                Console.WriteLine("Third: Square: " + Math.Round(triangles[2].Square()) +
                    " Perimeter: " + Math.Round(triangles[2].Perimeter()));
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
