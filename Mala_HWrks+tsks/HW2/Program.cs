using System;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.1
            //Console.WriteLine("Please enter three three decimal numbers one by one" + 
            //    "After entering each number, press 'Enter'");
            //float firstNum = float.Parse(Console.ReadLine());
            //float secondNum = float.Parse(Console.ReadLine());
            //float thirdNum = float.Parse(Console.ReadLine());

            //NumInRange checkNum = new();
            //checkNum.ChekNumIsInRange(firstNum, secondNum, thirdNum);


            //2.2
            //Console.WriteLine("Please enter three integer numbers one by one" +
            //    "After entering each number, press 'Enter'");
            //int firstNum = int.Parse(Console.ReadLine());
            //int secondNum = int.Parse(Console.ReadLine());
            //int thirdNum = int.Parse(Console.ReadLine());
            //FindMinMax findMaxMin = new();
            //findMaxMin.MinMax(firstNum, secondNum, thirdNum);

            //2.3
            //Console.WriteLine("Please enter number of error to know its meaning");
            //int num = int.Parse(Console.ReadLine());
            //HTTPErors myError = new();
            //myError.WhatIsError(num);

            //2.4
            //DogStruct dog = new();
            //Console.WriteLine("Please enter dog name");
            //dog.Name = Console.ReadLine();
            //Console.WriteLine("Please enter dog mark");
            //dog.Mark = Console.ReadLine();
            //Console.WriteLine("Please enter dog age");
            //dog.Age = Console.ReadLine();
            //Console.WriteLine(dog);

            //2.5
            Console.WriteLine("Feed your cat, available food: meat, fish, chicken, dry food, wet food" +
                "Enter the name of the cat food");
            string input = Console.ReadLine()?.ToLower().Replace(" ","");
            Cat kitty = new();
            kitty.SomethingToEat(input);

        }
    }
}
