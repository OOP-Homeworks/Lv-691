using System;

namespace HOMEWORK_6
{
    //Task 3

    class Program
    {
        private static object int32;

        static void ReadNumber(int start, int end)
        {
            int count = 1;
            int number;

            do
            {
            a1:
                try
                {
                    Console.Write("Number{0}: ", count);
                    number = Convert.ToInt32(Console.ReadLine());

                    if (number >= end || number <= start)
                    {
                        { throw new ApplicationException("Wrong input! Repeat, please."); }
                    }
                    else
                    {
                        start = number;
                    }
                    count++;
                }

                catch (ApplicationException exeption)
                {
                    Console.WriteLine(exeption.Message);
                    goto a1;
                }

                catch (FormatException exeption)
                {
                    Console.WriteLine(exeption.Message);
                    goto a1;
                }

            }
            while (count < 11);
        }


        static void Main(string[] args)
        {
            Console.Write("Enter start: ");
            int start = Int32.Parse(Console.ReadLine());
            Console.Write("Enter end: ");
            int end = Int32.Parse(Console.ReadLine());

            ReadNumber(start, end);
            Console.WriteLine("Victory!");
            Console.ReadLine();


            //Task 1-2

            try
            {
                Console.WriteLine("Enter two numbers:");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                if (b == 1) { throw new ApplicationException("b != 1"); }
                Console.WriteLine(Div(a, b));
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error",ex.Message);
            }

        }

        private static bool Div(int a, int b)
        {
            throw new NotImplementedException();
        }
    }           

}
