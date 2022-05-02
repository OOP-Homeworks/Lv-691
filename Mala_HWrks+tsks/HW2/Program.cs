using System;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.1
            //Console.WriteLine("Please enter three three decimal numbers one by one" + 
            //    "After entering each number, press 'Enter'");
            //float firstNum = float.Parse(Console.ReadLine());
            //float secondNum = float.Parse(Console.ReadLine());
            //float thirdNum = float.Parse(Console.ReadLine());

            //NumInRange checkNum = new();
            //checkNum.ChekNumIsInRange(firstNum, secondNum, thirdNum);


            //1.2
            //Console.WriteLine("Please enter three integer numbers one by one" +
            //    "After entering each number, press 'Enter'");
            //int firstNum = int.Parse(Console.ReadLine());
            //int secondNum = int.Parse(Console.ReadLine());
            //int thirdNum = int.Parse(Console.ReadLine());
            //FindMinMax findMaxMin = new();
            //findMaxMin.MinMax(firstNum, secondNum, thirdNum);

            //1.3
            Console.WriteLine("Please enter number of error to now its meaning");
            int num = int.Parse(Console.ReadLine());
            HTTPErors myError = new();
            myError.WhatIsError(num);

        }
    }
}
