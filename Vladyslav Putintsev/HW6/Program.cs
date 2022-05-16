using System;

namespace Homeworks
{
    internal class Part1
    {
        public void ShowPart1()
        {
        startagain:

            try
            {
                Console.WriteLine("Enter integer numerator");
                int numerator = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter integer denominator");
                int denominator = Convert.ToInt32(Console.ReadLine());
                if (numerator < denominator)
                {
                    throw new ApplicationException("Numerator cannot be less than denominator.");
                }
                Console.WriteLine($"Rresult:{Div(numerator, denominator)}");

                Console.WriteLine("Enter double numerator");
                double dNumerator = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter double denominator");
                double dDenominator = Convert.ToDouble(Console.ReadLine());
                if (dDenominator == 0)
                {
                    throw new ApplicationException("Denominator cannot be equal to 0");
                }
                Console.WriteLine($"Rresult:{DivDouble(dNumerator, dDenominator)}");

                Console.ReadKey();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denominator cannot be equal to 0");
                goto startagain;
            }
            catch (FormatException)
            {
                Console.WriteLine("Type mishmatch.");
                goto startagain;
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
                goto startagain;
            }

        }
        int Div(int n1, int n2)
        {
            return n1 / n2;
        }

        double DivDouble(double n1, double n2)
        {
            return n1 / n2;
        }
    }

    internal class Part2
    {
        public void ShowPart2()
        {
            int start = 1;
            int end = 100;
            int[] entered = new int[10];

            for(int i = 1; i < 11; i++)
            {
                start = ReadNumber(start, end);
                entered[i - 1] = start;

            }

            Console.WriteLine("Entered Values:");
            Console.Write("1");
            foreach(int i in entered)
            {
                Console.Write($" < {i}");
            }
            Console.Write(" < 100");
        }
        int ReadNumber(int start, int end)
        {
            int val;

            startagain:
            try
            {
                Console.WriteLine($"Enter Integer in a range ({start}-{end})");
                val=Convert.ToInt32(Console.ReadLine());
                if(val<=start || val >= end) { throw new ApplicationException($"The entered value not in an expected range ({start},{end}).Please try again."); }
            }
            catch(FormatException)
            {
                Console.WriteLine("Type mishmatch. Please try again.");
                goto startagain;
            }
            catch(ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
                goto startagain;
            }

            return val;
        }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            Part1 s1 = new Part1();
            s1.ShowPart1();

            Console.Clear();

            Part2 s2 = new Part2();
            s2.ShowPart2();

            Console.ReadKey();

            

            
        }

       
    }
}
