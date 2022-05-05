using System;
using System.Linq;

namespace hw3_osypov
{
    class Program
    {
        // Outputs the count of characters of given text
        Program CountsOfCharacters()
        {
            Console.WriteLine("Write some text");
            string s = Convert.ToString(Console.ReadLine());
            s = s.ToLower();
            int count = 0;
            
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'o' ||
                    s[i] == 'i' || s[i] == 'e' ) count++;
            }

            Console.WriteLine("Counts of characters (a, o, i, e) are " + count);
            Console.ReadKey();
            return this;
        }

        // Outputs the count of days in chosen month
        Program NumberOfMonth()
        {
            Console.WriteLine("Number of months");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[4] { 4, 6, 9, 11 };
            int[] b = new int[7] { 1, 3, 5, 7, 8, 10, 12 };
            
            switch (num)
            {
                case int i when a.Contains(i):
                    Console.WriteLine("This month has 30 days");
                    break;
                case int i when b.Contains(i):
                    Console.WriteLine("This month has 31 days");
                    break;
                case 2:
                    Console.WriteLine("This month has 28 or 29 days");
                    break;
                default:
                    break;
            }

            Console.ReadKey();
            return this;
        }

        // Outputs the math function
        Program TenNumbers()
        {
            Console.WriteLine("Enter 10 numbers: ");
            int[] numbers = new int[10];
            int sum = 0;
            int product = 1;
            
            for (int n = 0; n < 10; n++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                numbers[n] = num;
            }
            
            int i = 0;
            while(i < 5)
            {
                if (numbers[i] < 1)
                {
                    sum = 0;
                    i = 5;
                    break;
                }
                sum += numbers[i];
                i++;
            }
            if (sum > 0)
            {
                Console.WriteLine("The sum of the first 5 numbers is " + sum);
            } 
            else
            {
                while(i < 10)
                {
                    product *= numbers[i];
                    i++;
                }
                Console.WriteLine("The product of the last 5 numbers is " + product);
            }            
            Console.ReadKey();
            return this;
        }
        static void Main(string[] args)
        {
            new Program().CountsOfCharacters();
            new Program().NumberOfMonth();
            new Program().TenNumbers();
        }

    }
}