using System;
using System.Collections.Generic;

namespace hw6
{
    class Program
    {
        static int div_int(int first, int second)
        {
            if (second == 0) throw new DivideByZeroException();
            return first/second;
        }
        static double div_double(double first, double second)
        {
            if (second == 0) throw new DivideByZeroException();
            return first/second;
        }
            static int count= 0;
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter two integers to divide");
                int a = System.Convert.ToInt32(Console.ReadLine());
                int b = System.Convert.ToInt32(Console.ReadLine());
                int res = div_int(a, b);
                Console.WriteLine($"It's equal {res}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine("Enter two integers with float coma to divide");
                double x = System.Convert.ToDouble(Console.ReadLine());
                double y = System.Convert.ToDouble(Console.ReadLine());

                double res = div_double(x, y);
                Console.WriteLine($"It's equal {res}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            List<int> array = new List<int>();
            Console.WriteLine("Please enter 10 numbers in ascending order");
        proces:
            bool was_ex = false;
            try
            {
                for (int i = 0; i < 10; i++)
                {
                     if(was_ex)i = count;
                    int temp = System.Convert.ToInt32(Console.ReadLine());
                    array.Add(temp);
                    if (i != 0 && temp <= array[i - 1] ) throw new ArgumentException();
                    count++;
                    if (count == 10) break;
                }
            }
            catch (ArgumentException e)
            {
                was_ex = true;
                Console.WriteLine("Continue, but try not to break the rules");
                goto proces;
            }
            
        }
    }
}
