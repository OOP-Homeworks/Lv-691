using System;

namespace Homeworks
{
    internal class Program
    {
               
        static void Main(string[] args)
        {
            ///<summary>
            ///Read some string str.
            ///Calculate the counts of characters ‘a’, ’o’, ’i’, ’e’  in this text
            ///</summary>
            Console.WriteLine("Enter string");
            char[] chars = Console.ReadLine().ToLower().ToCharArray();
            int a = 0;
            int o = 0;
            int i = 0;
            int e = 0;
            foreach (char c in chars)
            {
                switch(c)
                {
                    case 'a':
                        a++;
                        break;
                    case 'o':
                        o++;
                        break;
                    case 'i':
                        i++;
                        break;
                    case 'e':
                        e++;
                        break;
                }
            }
            Console.WriteLine("count of a={0}, o={1}, i={2}, e={3}", a, o, i, e);

            ///<summary>
            ///Ask user to enter the number of month. 
            ///Read value and output the count of days in this month.
            ///</summary>

            Console.WriteLine("Enter Month number");
            int month=Convert.ToInt32(Console.ReadLine());
            int days=0;
            switch(month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                case 2:
                    days = 28;
                    break;
            }
            if(days>0)
            {
                Console.WriteLine("In month number {0}   {1} days.", month, days);
            }
            else
            {
                Console.WriteLine("Wrong month number should be from 1 to 12");
            }

            ///<summary>
            ///Enter 10 integer numbers.
            ///Calculate the sum of first 5 elements if they are positive or product of last 5 element in  the other case.
            ///</summary>

            int[] numbers = new int[10];
            bool positive = true;
            int result = 0;

            Console.WriteLine("Please enter 10 integer numbers.");
            for (int j = 0; j < 10; j++)
            {
                int nb = Convert.ToInt32(Console.ReadLine());
                numbers[j] = nb;
                if(nb<0)
                {
                    positive = false;
                }
            }

            if(positive)
            {
                for(int j = 0; j < 5; j++)
                {
                    result += numbers[j];
                }
            }
            else
            {
                result = 1;
                for (int j = 5; j < 10; j++)
                {
                    result *= numbers[j];
                }
            }

            Console.WriteLine("The result is {0}", result);

           Console.ReadKey();

            
        }

       
    }
}
