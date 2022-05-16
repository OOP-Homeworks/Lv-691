/**Define integer variable a (	). 
Read value from the console and calculate the area and perimeter of a square with length a. Output results on the console.
*/
using System;

namespace Exercises_1
{
    class SearchMathSquareAndPerimeter
    {
        static void Main(String[] args)
        {
            const int SECOND_DEGREE = 2;
            const int PERIMITER = 4;

            Console.WriteLine("Enter side of the square:");
            int userVelue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Area of square:\t{Math.Pow(userVelue, SECOND_DEGREE)}");
            Console.WriteLine($"Perimeter of square:\t{userVelue* PERIMITER}");

        }
    }
}