using HW1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Homeworks
{

    internal class Program
    {
               
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();
            triangles.Add(new Triangle(new Point(2, 3), new Point(4, 5), new Point(10, 12)));
            triangles.Add(new Triangle(new Point(6, 9), new Point(-124, 15), new Point(8, 1)));
            triangles.Add(new Triangle(new Point(-2, 7), new Point(4, 11), new Point(8, 4)));

            foreach (Triangle triangle in triangles)
            {
                Console.WriteLine(triangle.ToString());
            }

            Console.ReadKey();

            

            
        }

       
    }
}
