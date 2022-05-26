using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace hw9_osypov
{
    class Program
    {
        // Part A previous homework
        Program Shapes()
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
            Console.WriteLine("--------------------------");
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
            Console.WriteLine("--------------------------");

            var shapesRange = shapes.Where(i => i.Area() > 10 && i.Area() < 100);
            foreach (var i in shapesRange)
            {
                Console.WriteLine("Range[10, 100]: " + i.Area());
                using (StreamWriter sw = new StreamWriter(Path.Join("dictionary.txt"), true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(i.Area());
                }
            }
            Console.ReadKey();
            Console.WriteLine("--------------------------");

            var shapesContains = shapes.Where(i => i.Name.ToLower().Contains("a"));
            foreach (var i in shapesContains)
            {
                Console.WriteLine("shapes names that contains 'a': " + i.Name);
                using (StreamWriter sw = new StreamWriter(Path.Join("dictionary.txt"), true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(i.Name);
                }
            }
            Console.ReadKey();
            Console.WriteLine("--------------------------");

            shapes.RemoveAll(i => i.Perimeter() < 5);
            foreach (var i in shapes)
            {
                Console.WriteLine(i.Name + " " + i.Perimeter());
            }
            Console.ReadKey();
            Console.WriteLine("--------------------------");

            return this;
        }
        // Part B txt file
        Program TxtFormat()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            Console.WriteLine(projectDirectory);
            Dictionary<string, string> AnotherOne = new Dictionary<string, string>();
            
            string[] fileContent = File.ReadAllLines(Path.Join(projectDirectory, "AnotherOne.txt"), System.Text.Encoding.Default);

            for (int i = 0; i < fileContent.Length; i++)
            {
                Console.WriteLine($"Line {i}; chars:{fileContent[i].Length}");
            }

            string longestLine = fileContent.OrderByDescending(i => i.Length).First();
            Console.WriteLine(longestLine + " Is Longest");
            Console.WriteLine("--------------------------");

            string shortesLine = fileContent.OrderByDescending(i => i.Length).Last(); 
            Console.WriteLine(shortesLine + " Is Shortest");
            Console.WriteLine("--------------------------");

            foreach (string s in fileContent.ToList().FindAll(i => i.ToLower().Contains("var")))
            {
                Console.WriteLine("Lines that consist word 'var' is " + s);
            }
            Console.ReadKey();
            return this;
        }
        static void Main(string[] args)
        {
            new Program().Shapes().TxtFormat();
        }
    }
}
