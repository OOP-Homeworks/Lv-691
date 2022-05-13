using System;


namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Define integer variable a (side of the square).
            /// Read value from the console and calculate the area and perimeter of a square with length a. 
            /// Output results on the console.
            /// </summary>
            int a;
            Console.WriteLine("Please enter side of square length (Integer)");
            if ( Int32.TryParse(Console.ReadLine(),out a) )
            {
                Console.WriteLine("Area: {0}; Perimeter: {1}", (a * a), (a * 4));
            }
            else
            {
                Console.WriteLine("Wrong side of square length.");
            }

            ///<summary>
            ///Define string name and integer age.
            ///Output question "What is your name?";
            ///Read value name and output next question: "How old are you, (name)?".
            ///Read value age and output whole information  
            ///</summary>

            string name;
            int age;

            Console.WriteLine("What is your name?");

            name=Console.ReadLine();

            if( !String.IsNullOrEmpty(name) )
            {
                Console.WriteLine("How old are you, {0}?", name);
                if (Int32.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Name: {0}; Age: {1}", name, age);
                }
                else
                {
                    Console.WriteLine("Wrong age.");
                }
            }
            else
            {
                Console.WriteLine("Please enter your name.");
            }

            ///<summary>
            ///Read double number r (radius of a circle).
            ///Calculate the length (l=2*pi*r), area (S=pi*r*r), and volume (4/3*pi*r*r*r) of a circle.
            ///</summary>

            Console.WriteLine("Please enter radius");
            if (Double.TryParse(Console.ReadLine(), out double r))
            {
                double l=2*Math.PI*r;
                double s = Math.PI * Math.Pow(r,2);
                double v = 4 / (double)3 * Math.PI * Math.Pow(r, 3);
                Console.WriteLine("Length: {0}; Area: {1}; Volume: {2}", l, s,v);
            }
            else
            {
                Console.WriteLine("Wrong radius.");
            }

            Console.ReadLine();
        }
            
            
    }
}
