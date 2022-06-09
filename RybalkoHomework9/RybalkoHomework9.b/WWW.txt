using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RybalkoHomework8
{
    internal class Program
    {
        private static void Main()
        {
            List < Shape > shapes = new List<Shape>();
            for(int x = 0; x < 10; x++)
            {
                A1:
                Console.WriteLine("What type of figure?(square/circle)");
                string tip = Console.ReadLine().ToLower();
                Console.Write("name = ");
                string name = Console.ReadLine();
                if(tip == "square")
                {
                    Console.WriteLine("side = ");
                    int side = Convert.ToInt32(Console.ReadLine());
                    shapes.Add(new Square(name, side));
                }
                if(tip == "circle")
                {
                    Console.Write("R =");
                    int r = Convert.ToInt32(Console.ReadLine());
                    shapes.Add(new Circle(name, r));
                }
                if(tip != "square" && tip != "circle")
                {
                    Console.WriteLine("does not have this type!");
                    goto A1;
                }
            }
            foreach (Shape x in shapes)
            {
                x.Print();
            }
            Shape larkk = shapes[0];
            for(int x = 1; x< 10; x++)
            {
                if (shapes[x].perimeter > larkk.perimeter)
                {
                    larkk = shapes[x]; 
                }
            }
            Console.WriteLine(larkk.Name);
            shapes.Sort();
            foreach(Shape x in shapes)
            {
                x.Print();
            }
        }
    }
}