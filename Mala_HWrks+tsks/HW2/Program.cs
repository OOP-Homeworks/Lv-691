using System;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three three decimal numbers one by one" + 
                "After entering each number, press 'Enter'");
            float firstNum = float.Parse(Console.ReadLine());
            float secondNum = float.Parse(Console.ReadLine());
            float thirdNum = float.Parse(Console.ReadLine());

            NumInRange checkNum = new();
            checkNum.ChekNumIsInRange(firstNum, secondNum, thirdNum);
        }
    }
}
