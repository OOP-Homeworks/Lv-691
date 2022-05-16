using System;

namespace hw6_osypov
{
    class Program
    {
        public void DividingTwoNumbers()
        {
        back:
            try
            {
                Console.WriteLine("Enter 2 numbers");
                Console.Write("a = ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                if (a < b) { throw new ApplicationException("a must be greater than b"); }
                Console.WriteLine("{0} / {1} = {2}", a, b, Div(a, b));

                Console.WriteLine("Enter 2 numbers");
                Console.Write("num1 = ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("num2 = ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                if (num2 == 0) { throw new DivideByZeroException(); }
                Console.WriteLine("{0} / {1} = {2}", num1, num2, NewMethod(num1, num2));
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
                goto back;
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Error", exception.Message);
                goto back;
            }
            catch (ApplicationException exception)
            {
                Console.WriteLine(exception.Message);
                goto back;
            }
            finally
            {
                Console.WriteLine("Congratulation!");
            }
            Console.ReadKey();
        }

        private static double NewMethod(double num1, double num2)
        {
            return num1 / num2;
        }

        private static int Div(int a, int b)
        {
            return a / b;
        }

        public class NumberRange
        {
            public void ReadNumber(int start, int end)
            {
            start:
                try
                {
                    int[] array = new int[10];
                    int j = 1;
                    int currentValue;
                    for (int i = 0; i < 10; i++, j++)
                    {
                        itteration:
                        try
                        {
                            Console.WriteLine("Enter number a" + j);
                            currentValue = Int32.Parse(Console.ReadLine());
                            if (currentValue <= start || currentValue >= end)
                            {
                                Console.WriteLine("Out of range [1..100]: " + currentValue);
                                goto itteration;
                            }
                            if (i > 0 && currentValue <= array[i - 1])
                            {
                                Console.WriteLine("Value is less or equal last element");
                                goto itteration;
                            }
                            array[i] = currentValue;
                        }
                        catch (FormatException formatEx)
                        {
                            Console.WriteLine("Invalid number", formatEx);
                            goto itteration;
                        }  
                    }

                    Console.WriteLine("Array Values Are: " + String.Join(" ,", array));
                    
                }
                catch (ApplicationException exception)
                {
                    Console.WriteLine(exception.Message);
                    goto start;                 
                }
                finally
                {
                    Console.WriteLine("Congratulation!");
                }
            }
        }

        static void Main(string[] args)
        {
            new Program().DividingTwoNumbers();
            NumberRange range = new NumberRange();
            range.ReadNumber(1, 100);
            Console.ReadKey();
        }
    }
}

