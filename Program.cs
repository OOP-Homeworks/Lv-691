using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_3

{
    class Program
    {
        private static int Main(string[] args)
        {
            //1

            Console.WriteLine("Enter two int numbers");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = a + 1; i < b; i++)
            {
                if (i % 3 == 0) count++;
            }
            Console.WriteLine($"Answer {count}\n");

            //2

            Console.WriteLine("Enter long word");
            string str = Console.ReadLine();
            char[] chars;
            chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(chars[i]);
                }
            }

            //3

            Console.WriteLine("Choose one of drinks: coffe/tea/juice/water");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "coffe":
                    Console.WriteLine("The price of coffe is 2.00");
                    break;
                case "tea":
                    Console.WriteLine("The price of tea is 1.50");
                    break;
                case "juice":
                    Console.WriteLine("The price of juice is 2.20");
                    break;
                case "water":
                    Console.WriteLine("The price of water is 0,50");
                    break;
            }

            //4
            int list = 0;
            List<int> lists = new List<int>();
            do
            {
                Console.WriteLine("Write some integer");
                list = Convert.ToInt32(Console.ReadLine());
                if (list > 0)
                {
                    lists.Add(list);
                }
            }
            while (list > 0);

            if (lists.Count > 0)
            {
                double average = lists.AsQueryable().Sum() / (double)lists.Count();
                Console.WriteLine($"Sum is {average}");
            }
            else
            {
                Console.WriteLine("No positive integers");
            }


            //5
            Console.WriteLine("Write a year");
            int year;
            year = Convert.ToInt32(Console.ReadLine());
            static void IsLeapYear(int v, int year) => throw new NotImplementedException();
            Console.WriteLine(true ? "The year is leap" : "The year is not leap");


            //6
            Console.WriteLine("Write a number");
            int value = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            while (value > 0)
            {
                res += value % 10;
                value /= 10;
                Console.WriteLine($"The sum is {res}");
            }
            return (res);

            //7
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            Console.WriteLine("Write a number");
            while (num < 0)
            {
                result += num % 10;
                num /= 10;
            }
            if (result % 2 != 0)
                Console.WriteLine("integer contains odd digits");


            //1
            Console.WriteLine("Enter some string");
            string word = Console.ReadLine();
            char[] letter;
            letter = word.ToCharArray();
            for (int l = 0; l < word.Length; l++)
            {
                if (word[l] == 'a')
                    Console.WriteLine($"There are {letter[l]} letters 'a'");
            }
            for (int l = 0; l < word.Length; l++)
            {
                if (word[l] == 'o')
                    Console.WriteLine($"There are {letter[l]} letters 'o'");
            }
            for (int l = 0; l < word.Length; l++)
            {
                if (word[l] == 'i')
                    Console.WriteLine($"There are {letter[l]} letters 'i'");
            }
            for (int l = 0; l < word.Length; l++)
            {
                if (word[l] == 'e')
                    Console.WriteLine($"There are {letter[l]} letters 'e'");


                //2
                Console.WriteLine("Write the nomber of month");
                int month = Convert.ToInt32(Console.ReadLine());
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Console.WriteLine("There are 31 days in this month");
                        break;
                    case 2:
                        Console.WriteLine("There are 28 or 29 days in this month");
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Console.WriteLine("There are 30 days in this month");
                        break;
                }

                //3
                Console.WriteLine("Enter 10 integer numbers");
                int[] nums = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    nums[i] = int.Parse(Console.ReadLine());
                }
                int sum1 = 0;
                foreach (int i in nums)
                {
                    if (num >= 0 && i < 5)
                    {
                        sum1 += i;
                    }
                }
                Console.WriteLine($"The sum or 5 first elements is {sum1}");
                int sum2 = 0;
                foreach (int i in nums)
                {
                    if (num < 0 && i < 5)
                    {
                        sum2 = nums[5] + nums[6] + nums[7] + nums[8] + nums[9];
                    }
                }
                Console.WriteLine($"The sum of 5 last elements is {sum2}");

                Console.ReadKey();
            }
        }
    }
}








       