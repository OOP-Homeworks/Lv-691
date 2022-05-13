using System;

namespace MalaOks_Task1
{
    internal class Task1
    {
        public static void Task1_2()
        {
            Console.WriteLine("How are you");
            string answer = Console.ReadLine();
            Console.WriteLine($"You are {answer}");
        }

        public static void Task1_3()
        {
            Console.WriteLine("Please enter any three letters or numbers one by one. " +
                "After entering each letter, press 'Enter'");
            char a, b, c;
            a = Convert.ToChar(Console.ReadLine());
            b = Convert.ToChar(Console.ReadLine());
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"You enter {a}, {b},{c}");
        }

        public static void Task1_4()
        {
            Console.WriteLine("Please enter any two numbers one by one. " +
                "After entering each number, press 'Enter'");
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            bool c = a > 0 & b > 0;
            if (c)
            {
                Console.WriteLine("Both numbers positive");
            }
            else
            {
                Console.WriteLine("One of numbers is not positive or both numbers are not positive");
            }
        }

        static void Main(string[] args)
        {
            Task1_2();
            //Task1_3();
            //Task1_4();
        }
    }
}
