using System;

namespace hw2_osypov
{
    class Program
    {
        enum HttpError
        {
            Bad_Request = 400,
            Unauthorized = 401,
            Payment_Required = 402,
            Forbidden = 403,
            Not_Found = 404
        }
        struct Dog
        {
            public string name;
            public string mark;
            public int age;

            public void Info()
            {
                Console.WriteLine("Name of the dog = " + name + ", mark = " + mark + ", age = " + age);
            }

        }
        // Check your numbers are range of [-5.5]
        Program ThreeFloatNumbers()

        {
            Console.WriteLine("Write a float 3 numbers");
            Console.Write("Number_1 = ");
            float num1 = Single.Parse(Console.ReadLine());

            Console.Write("Number_2 = ");
            float num2 = Single.Parse(Console.ReadLine());

            Console.Write("Number_3 = ");
            float num3 = Single.Parse(Console.ReadLine());

            Console.WriteLine(num1 >= -5 && num1 <= 5 ?
                              "Number " + (num1) + " in range [-5.5]" :
                              "Number " + (num1) + " out of range [-5.5]");
            Console.WriteLine(num2 >= -5 && num2 <= 5 ?
                              "Number " + (num2) + " in range [-5.5]" :
                              "Number " + (num2) + " out of range [-5.5]");
            Console.WriteLine(num3 >= -5 && num3 <= 5 ?
                              "Number " + (num3) + " in range [-5.5]" :
                              "Number " + (num3) + " out of range [-5.5]");
            Console.ReadKey();
            return this;
        }

        // Outputs the Max and Min of the three numbers 
        Program MaxMinNumber()
        {

            Console.WriteLine("Write 3 numbers to display the max and min of them");
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Max value is " + Math.Max(Math.Max(a, b), c));
            Console.WriteLine("Min value is " + Math.Min(Math.Min(a, b), c));
            Console.ReadKey();
            return this;
        }

        // Outputs the name of the errors from 400 to 404
        Program ErrorNumber()
        {
            Console.WriteLine("Write number from 400 to 404");
            int errornum = Convert.ToInt32(Console.ReadLine());
            HttpError error = (HttpError)errornum;
            Console.Write("HTTP error is  " + error.ToString().Replace("_", " "));
            Console.ReadKey();
            return this;
        }

        // Outputs information of the dog name, mark and age
        Program MyDog()
        {
            Dog MyDog = new Dog();
            string name = Convert.ToString(Console.ReadLine());
            MyDog.name = "Basilisk";
            MyDog.mark = "Akita_Inu";
            MyDog.age = 4;
            MyDog.Info();
            Console.ReadKey();
            return this;

        }
        static void Main(string[] args)
        {
            new Program().ThreeFloatNumbers();
            new Program().MaxMinNumber();
            new Program().ErrorNumber();
            new Program().MyDog();
        }

        }    
    }

