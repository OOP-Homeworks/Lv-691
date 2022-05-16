/**Read double number r (radius of a circle).*/
using System;

namespace Exercises_1
{
    class Program
    {
        static void Main(String[] args)
        {
                Console.WriteLine("Input the radius of the circle: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                double perCir = 2 * Math.PI * radius;
                Console.Clear();
                Console.WriteLine($"Perimeter of Circle: {perCir}");
                
        }
    }
}