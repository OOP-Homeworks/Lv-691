using System;

namespace hw2
{
    class Program
    {
            enum HTTPError
            {
               BadRequest=400,
               Unauthorized,
               PaymentRequired,
               Forbidden,
               NotFound,
               MethodNotAllowed,
              NotAcceptable,
        }
            struct Dog
            {
                public string name;
                public string mark;
                public int age;

                public override string ToString()
            {
                return string.Format($"Name: {name}\nMark: {mark}\nAge: {age}");
            }
            }
        static void Main(string[] args)
        {
            Console.WriteLine("1)");
            bool check(float num)
            {
                return (num >= -5 && num <= 5);
            }
            Console.WriteLine("enter three float num: ");
            float num1 = Single.Parse(Console.ReadLine());
            float num2 = Single.Parse(Console.ReadLine());
            float num3 = Single.Parse(Console.ReadLine());
            Console.WriteLine(check(num1) ? "num1 is in the range " : "num1 is not in the range");
            Console.WriteLine(check(num2) ? "num2 is in the range " : "num2 is not in the range");
            Console.WriteLine(check(num3) ? "num3 is in the range " : "num3 is not in the range");

            Console.WriteLine("2)");
            Console.WriteLine("enter three integers: ");
            int max(int num1, int num2, int num3)
            {
                if (num1 >= num2 && num1 >= num3) return num1;
                else if (num2 >= num1 && num2 >= num3) return num2;
                else if (num3 >= num1 && num3 >= num2) return num3;
                return 0; //without this Error  not all code paths return a value 

            }
            int min(int num1, int num2, int num3)
            {
                if (num1 <= num2 && num1 <= num3) return num1;
                else if (num2 <= num1 && num2 <= num3) return num2;
                else if (num3 <= num1 && num3 <= num2) return num3;
                return 0; //without this Error  not all code paths return a value 
            }
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int third = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Max: { max(first, second, third)}");
            Console.WriteLine($"Min: { min(first, second, third)}");

            Console.WriteLine("3)");
            Console.WriteLine("Enter num of HTTP error (400, ..., 406");
            int errornum = Convert.ToInt32(Console.ReadLine());
            HTTPError error =(HTTPError) errornum;
            Console.WriteLine( error);

            Console.WriteLine("4)");
            Dog myDog;
            myDog.name = "Javelin";
            myDog.mark = "Amerikana";
            myDog.age = 8;
            Console.WriteLine(myDog);
        }
    }
}
