using System;

namespace Homework_2
{
    class Program
    {
        enum TestCaseStatus { Pass, Fail, Blocked, WP, Unexecuted };

        enum HTTPError
        {
            BadRequest = 400,
            Unauthorized,
            PaymentRequired,
            Forbidden,
            NotFound
        };

        struct RGB
        {
            public byte red;
            public byte green;
            public byte blue;

            public void ColorChoose ()
            {
                Console.WriteLine("Please write three numbers of RGB (1 or 0)");
                red = Convert.ToByte(Console.ReadLine());
                green = Convert.ToByte(Console.ReadLine());
                blue = Convert.ToByte(Console.ReadLine());

                if (red == 0 && green == 0 && blue == 0)
                {
                    Console.WriteLine("The colour is white");
                }
                else if (red == 1 && green == 1 && blue == 1)
                {
                    Console.WriteLine("The colour is black");
                }
   
            }
            
        }

        struct Dog
        {
            public string name;
            public string mark;
            public int age;

            public void Info()
            {
                Console.WriteLine($"I have a dog {name}, mark {mark}, {age} years old");
            }
        }

        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Write the first number");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0 & a <= 31)
                Console.WriteLine("The day of month is correct");
            else
                Console.WriteLine("The day of month is incorrect");
            int b;
            Console.WriteLine("Write the second number");
            b = Convert.ToInt32(Console.ReadLine());
            if (b > 0 & b < 13)
                Console.WriteLine("The number of month is correct");
            else
                Console.WriteLine("The number of month is incorrect");


            double c;
            Console.WriteLine("Write double number");
            c = Convert.ToDouble(Console.ReadLine());
            int t = (int)(c * 100);
            double d = t % 10;
            double f = (t % 100 - t % 10) / 10;
            Console.WriteLine($"Sum is {d + f}");


            int time;
            Console.WriteLine("Write time");
            time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((time > 6) && (time <= 9) ? "morning" :
                (time > 9) && (time <= 15) ? "afternoon" :
                (time > 15) && (time <= 23) ? "evening" :
                (time >= 0) && (time <= 6) ? "night" :
                "error");


            TestCaseStatus test1Status = TestCaseStatus.Pass;
            if (test1Status == TestCaseStatus.Pass)
                Console.WriteLine("test1Status is Pass");
            else
                Console.WriteLine("test1Status is not passed");


            var struct1 = new RGB();
            struct1.ColorChoose();


            float one;
            Console.WriteLine("Write the first float number");
            one = Convert.ToSingle(Console.ReadLine());
            float two;
            Console.WriteLine("Write the second float number");
            two = Convert.ToSingle(Console.ReadLine());
            float three;
            Console.WriteLine("Write the third number");
            three = Convert.ToSingle(Console.ReadLine());
            if ((one >= -5 && one <= 5) && (two >= -5 && two <= 5) && (three >= -5 && three <= 5))
                Console.WriteLine("All numbers are in range -5.5");
            else
                Console.WriteLine("At least one number is not in range -5.5");


            int first;
            Console.WriteLine("Write the first number");
            first = Convert.ToInt32(Console.ReadLine());
            int second;
            Console.WriteLine("Write the second number");
            second = Convert.ToInt32(Console.ReadLine());
            int third;
            Console.WriteLine("Write the third number");
            third = Convert.ToInt32(Console.ReadLine());
            int e = Math.Max(first, second);
            int l = Math.Max(e, third);
            Console.WriteLine($"Max value is {l}");
            int k = Math.Min(first, second);
            int w = Math.Min(k, third);
            Console.WriteLine($"Min value is {w}");


            Console.WriteLine("Write the number of HTTP error from 400 to 404");
            int errorNumber;
            errorNumber = Convert.ToInt32(Console.ReadLine());
            HTTPError error = (HTTPError)errorNumber;
            Console.WriteLine(error);


            Dog myDog;
            myDog.name = "Lord";
            myDog.mark = "Shpitz";
            myDog.age = 2;
            myDog.Info();
        }
    }
}



        
        






