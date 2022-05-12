using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;




namespace Andrii_HomeWork_2
{

    class Program
    {
        enum HttpStatusCode { Accepted = 202, AlreadyReported = 208, Ambiguous = 300 }
        struct Dog
        {
            public string name, maark;
            public int age;

            public void DisplayInfo()
            {
                Console.WriteLine($"Name {name}. mark {maark}. age {age}");
            }
        }



        static void Main()
        {


            Task1();
            Task2();
            Task3();
            Task4();

        }
        static void Task1()
        {
            const float MIN_USER_VALUE = -5f;
            const float MAX_USER_VALUE = 5f;

            float[] Arry = new float[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter number {i}");
                Arry[i] = Convert.ToSingle(Console.ReadLine());

            }
            for (int i = 0; i < 3; i++)
            {
                if (Arry[i] >= MIN_USER_VALUE && Arry[i] <= MAX_USER_VALUE)
                {
                    Console.WriteLine($"The value is in the range:{Arry[i]}.");
                }
                else
                {
                    Console.WriteLine($"Value is out of range:{Arry[i]}.");
                }

            }
        }
        static void Task2()
        {
            {

                int[] arry = new int[] {10,9,8,7,6,5,4,3,2,1};

                //for (int i = 0; i < arry.Length; i++)
                //{
                //    Console.WriteLine($"Please enter number {++userIndexNumber}");
                //    arry[i] = Convert.ToInt32(Console.ReadLine());
                //}

                int maxValue = 0;
                int minValue = arry[0];

                for (int i = 0; i < arry.Length; i++)
                {
                    if (arry[i]>=maxValue)
                    {
                        maxValue = arry[i];
                    }
                    if (arry[i] <= minValue)
                    {
                        minValue = arry[i];
                    }



                }


                Console.WriteLine($"MaxValue:{maxValue}.\nMinValue:{minValue}.");
                //Використати одномірни масив, який буде перебирати змінні. 
            }


        }
        static void Task3()
        {
            while (true)
            {
                Console.WriteLine("Enter HTTP error");
                int numberError = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine((HttpStatusCode)numberError);
            }
        }

        static void Task4()
        {
            Dog barsik;
            barsik.age = 12;
            barsik.name = "barsik";
            barsik.maark = "Buldog";
            barsik.DisplayInfo();
        }


    }
}





