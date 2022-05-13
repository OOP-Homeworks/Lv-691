using System;

namespace MalaOks_HW3_tsk3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.1
            //Console.WriteLine("Enter a sentence consisting at least several words");
            //string sourse = Console.ReadLine();
            //CalculateCharactersInStr charactCount = new();
            //int count = charactCount.ContCharacters(sourse);
            //Console.WriteLine($"Number of letters a’, ’o’, ’i’, ’e’ in the entered text: {count}");

            //3.2
            //Console.WriteLine("Enter year and month number to get number of days in this month. Enter first year," +
            //    "then press 'Enter' then enter number of month");
            //int year = Convert.ToInt32(Console.ReadLine());
            //int month = Convert.ToInt32(Console.ReadLine());
            //CountDaysInMonth daysInMnth = new();
            //int days = daysInMnth.DaysInMonth(year, month);
            //Console.WriteLine($"Days in month: {month} in year: {year} = {days}");

            //3.3
            Console.WriteLine("Enter ten numbers one after the other positive or negative or mixed");
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            CheckPositiveSum5 sum5 = new();
            sum5.SumOf5(arr);
            Console.WriteLine($"Sum of 5 entered numbers = {sum5.Sum}");

        }
    }
}
