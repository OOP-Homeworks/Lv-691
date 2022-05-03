using System;

namespace hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            // ~~~~~~~~~~~~~~task 1~~~~~~~~~~~~~~~~~~~~
            Console.WriteLine("Input string please: ");
            string str =Console.ReadLine();
            str = str.ToLower();
            int count = 0;
            for (int i = 0 ; i<str.Length; i++)
            {
                if (str[i] == 'a'|| str[i] == 'o'|| str[i] == 'i'|| str[i] == 'a') count++;
            }
            Console.WriteLine($"Answer:{count} \n");

            // ~~~~~~~~~~~~~~task 2~~~~~~~~~~~~~~~~~~~~

            bool right_input = false;
            while(!right_input)
            {
                Console.WriteLine("Enter number of your month");
                int month = System.Convert.ToInt32(Console.ReadLine());

                switch(month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Console.WriteLine("This month has 31 days");
                        right_input = true;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Console.WriteLine("This month has 30 days");
                        right_input = true;
                        break;
                    case 2:
                        Console.WriteLine("This month has 28 or even 29 days");
                        right_input = true;
                        break;
                    default:
                        Console.WriteLine("Wrong input. Let's try again ");
                        break;
                }
            }
            // ~~~~~~~~~~~~~~task 3~~~~~~~~~~~~~~~~~~~~
            Console.WriteLine("Enter 10 numbers: ");

            int[] arr = new int[10];
            int first_positive = 0;
            for (int i=0; i<10; i++)
            {
                int n = System.Convert.ToInt32(Console.ReadLine());
                arr[i] = n;
                while(i<5)
                {
                   if(n>0) first_positive++;
                    break;
                }
            }
            if(first_positive==5)
            {
            int sum = 0;
                for (int i = 0; i < 5; i++)
                {
                    sum += arr[i];
                }
                Console.WriteLine($"Answer: {sum}");
            }
            else
            {
            int prod = 1;
                for (int i = 9; i >= 5; i--)
                {
                    prod *= arr[i];
                }
                Console.WriteLine($"Answer: {prod}");
            }
          
        }
    }
}
