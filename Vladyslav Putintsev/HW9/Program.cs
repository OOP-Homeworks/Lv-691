using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Homeworks
{
    static class PartA
    {
        public static void Run()
        {
            List<Shape> shapes = new List<Shape>();

            Shape shape = new Circle("First Cirlce", 10);
            shapes.Add(shape);
            shape = new Square("First Square", 5);
            shapes.Add(shape);
            shape = new Circle("Second Cirlce", 2.3);
            shapes.Add(shape);
            shape = new Square("Second Square", 3.8);
            shapes.Add(shape);
            shape = new Circle("Third Cirlce", 6);
            shapes.Add(shape);
            shape = new Square("Third Square", 9);
            shapes.Add(shape);

            List<Shape> shapeRange = shapes.FindAll(x => x.Area() >= 10 && x.Area() <= 100);
            using (StreamWriter sw = new StreamWriter(@"C:\D\RangeShapes.txt", false, System.Text.Encoding.Default))
            {
                foreach (var s in shapeRange)
                {
                    sw.WriteLine(s.ToString());
                }
            }

            List<Shape> shapeContains = shapes.FindAll(x => x.Name.ToLower().Contains("a"));
            using (StreamWriter sw = new StreamWriter(@"C:\D\ContainCharShapes.txt", false, System.Text.Encoding.Default))
            {
                foreach (var s in shapeContains)
                {
                    sw.WriteLine(s.ToString());
                }
            }

            shapes.RemoveAll(x => x.Perimeter() < 5);
            foreach (var s in shapes)
            {
                Console.WriteLine(s.ToString());
            }
        }
    }

    static class PartB
    {
        public static void Run()
        {
            string[] fileContent = File.ReadAllLines(@"C:\D\AlotOfText.txt", System.Text.Encoding.Default);
            

           for(int i=0;i<fileContent.Length;i++)
            {
                Console.WriteLine($"Line {i}; chars:{fileContent[i].Length}");
            }

            string longestLine = fileContent.OrderByDescending(x => x.Length).First();
            Console.WriteLine($"THE LINE {longestLine} IS LONGEST");

            string shortesLine = fileContent.Where(x=>x.Length>0).OrderByDescending(x => x.Length).Last();   //Get shortest, but not empty!
            Console.WriteLine($"THE LINE {shortesLine} IS SHORTEST");

            foreach (string s in fileContent.ToList().FindAll(x => x.ToLower().Contains("var")))
            {
                Console.WriteLine(s);
            }
        }
    }

    internal class Program
    {
               
        static void Main(string[] args)
        {

            PartA.Run();

            PartB.Run();
           
            Console.ReadKey();

            

            
        }

       
    }
}
