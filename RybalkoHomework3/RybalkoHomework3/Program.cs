using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RybalkoHomework3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Execes1();
            Execes2();
            Execes3();
        }
        private static void Execes1()
        {
            int sumA = 0;
            int sumO = 0;
            int sumI = 0;
            int sumE = 0;
            Console.WriteLine("enter a word, please");
            string text = Console.ReadLine();
            foreach (char i in text)
            {
                _ = i == 'a' ? sumA++ : (i == 'o' ? sumO++ : (i == 'i' ? sumI++ :
                    (i == 'e' ? sumE++ : 0)));
            }
            Console.WriteLine($"a = {sumA} o = {sumO} i = {sumI} e = {sumE}");
        }
        private static void Execes2()
        {
            Console.Write("Enter month -");
            int monthX = Convert.ToInt32(Console.ReadLine());
            DateTime dataX = new DateTime(2022, monthX, 1);
            TimeSpan daysX = (dataX.AddMonths(1).Subtract(dataX));
            Console.WriteLine($"There are {daysX.Days} days this month");
        }
        private static void Execes3()
        {
            int[] nums = new int[10];
            bool result = true;
            int sum = 0;
            int dob = 1;
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine($"enter the number {x + 1}");
                nums[x] = Convert.ToInt32(Console.ReadLine());
                if (x < 5)
                {
                    result = result & nums[x] > 0;
                }
            }
            if (result)
            {
                for (int x = 0; x < 5; x++)
                {
                    sum = sum + nums[x];
                }
                Console.WriteLine($"all 5 numbers are positive. Their sum is equal to {sum}");
            }
            else
            {
                for(int x= 9; x > 4; x--)
                {
                    dob = dob * nums[x];
                }
                Console.WriteLine($"Not all the first 5 digits are positive. Therefore the product of the last 5 is equal {dob}");
            }
            Console.ReadLine();
        }
    }
}
