using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RybalkoHomework10
{
    internal class Program
    {
        private static void Main()
        {
            List<Triangle> Triangles = new List<Triangle>();
            Triangles.Add(new Triangle(new Point(1, 2), new Point(6, 7), new Point(25, 60)));
            Triangles.Add(new Triangle(new Point(2, 3), new Point(7, 8), new Point(26, 61)));
            Triangles.Add(new Triangle(new Point(6, 7), new Point(11, 12), new Point(30, 65)));
            foreach(Triangle x in Triangles)
            {
                x.Print();
            }
            Console.ReadLine();
        }
    }
}
