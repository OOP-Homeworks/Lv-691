using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RybalkoHomework6
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Div(a, b);

            Console.Write("a2 = ");
            Double a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("b2 = ");
            Double b2 = Convert.ToDouble(Console.ReadLine());
            Div2(a2, b2);

            Console.WriteLine("Enter the beginning of the space");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the end of the space");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of entries");
            int amount  = Convert.ToInt32(Console.ReadLine());
            ReadNumber(start, end, amount);
        }
        static int Div(int divided, int divider)
        {
            try
            {
                Console.WriteLine($" {divided} / {divider} = {divided / divider}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return divided + divider;
        }
        static double Div2(Double divided2, double divider2)
        {
            if(divider2 == Convert.ToDouble(0))
            {
                throw new ApplicationException("The number must not be zero!!!");
            }
            Console.WriteLine($" {divided2} / {divider2} = {divided2 / divider2}");
            return divider2 + divided2;
        }
        static int ReadNumber(int start, int end, int n)
        {
            int[] number = new int [n];
            Ex1:
            try
            {
                for (int x = 0; x < n; x++)
                {
                    Console.Write($"enter the number {x+1} = ");
                    int readnumber = Convert.ToInt32(Console.ReadLine());
                    if (readnumber < start || readnumber > end)
                    {
                        throw new ApplicationException($"The number must be in the range from {start} to {end}");
                    }
                    if(x != 0)
                    {
                        if(number[x-1] > readnumber)
                        {
                            throw new ApplicationException("Each subsequent number must be greater than the past!!!");
                        }
                    }
                    number[x] = readnumber;
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto Ex1;
            }
            for (int x = 0; x < n; x++)
            {
                Console.WriteLine(number[x]);
            }
                return number[n];
        }
    }
}
    
