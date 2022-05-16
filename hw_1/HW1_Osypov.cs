using System;

namespace HW1_Osypov
{
    class Program
    {
        Program PersonalInfo()
        {
            // Ask the user to type his/her name.
            Console.WriteLine("What is your name?");
            // Read value Name
            string name = Convert.ToString(Console.ReadLine()); 

            // Ask the user to type his/her age
            Console.WriteLine("How old are you, {0}?", name);
            // Read value Years
            int age = Convert.ToInt32(Console.ReadLine()); 

            // Output whole information
            Console.WriteLine("Name: {0}, Age: {1}", name, age);
            Console.ReadKey();
            return this;
        }
        Program MathSquare()
        {
            // Ask the user to type the number
            Console.Write("Enter a(side of square) = ");

            // Read value from the console
            int a = Convert.ToInt32(Console.ReadLine()); 
            
            // Outputs the area and perimeter of a square with given length            
            Console.WriteLine("Area of square {0} ^ 2 = {1}", a, Math.Pow(a, 2)); 
            Console.WriteLine("Perimeter of square {0} * 4 = {1}", a, a * 4); 
            Console.ReadKey();
            return this;
        }
        Program MathCircle()
        {
            Console.Write("Enter r(radius of square) = ");

            // Read value from the console
            double r = Convert.ToDouble(Console.ReadLine());
            
            // Get PI from the .NET Math class constant            
            double d = Math.PI; 

            // Outputs the length, area, and volume of a circle from given variable            
            Console.WriteLine("Length of circle:  {1:N2} * {0} * 2 = {2:F2}", r, d, r * d * 2);
            Console.WriteLine("Areaw of circle :({0} ^ 2) * {1:N2} = {2:F2}", r, d, Math.Pow(r, 2) * d );
            Console.WriteLine(
                "Volume of circle: (4 / 3) * {0} ^ 3 * {1:N2} = {2:F2}",
                r, d, ((double)4 / 3) * Math.Pow(r, 3) * d
            );
            Console.ReadKey();
            return this;
        }
        static void Main(string[] args)
        {
            new Program().PersonalInfo().MathSquare().MathCircle();
        } 
    }
}
