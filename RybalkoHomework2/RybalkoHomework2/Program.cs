using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RybalkoHomework1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Execes1();
            Execes2();
            Execes3();
            Execes4();
        }
        private static void Execes1()
        {
            Console.WriteLine("Enter the first number");
            float number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            float number2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            float number3 = float.Parse(Console.ReadLine());
            string answer = (number1 >= -5 && number1 <= 5) ? $"{number1} is in the range [-5.5]" : $"{number1} not included in the interval [-5.5]";
            Console.WriteLine(answer);
           answer = (number2 >= -5 && number2 <= 5) ? $"{number2} is in the range [-5.5]" : $"{number2} not included in the interval [-5.5]";
            Console.WriteLine(answer); 
           answer = (number3 >= -5 && number3 <= 5) ? $"{number3 }is in the range [-5.5]" : $"{number3} not included in the interval [-5.5]";
            Console.WriteLine(answer); 
        }
        private static void Execes2()
        {
            Console.WriteLine("Enter the first number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int number3 = Convert.ToInt32(Console.ReadLine());
            string answer = (number1 > number2) ? ((number1 > number3) ? $"max={number1}": $"max={number3}") : ((number2>number3)? $"max={number2}": $"max={number3}");
            Console.WriteLine(answer);
            answer= (number1 < number2) ? ((number1 < number3) ? $"min={number1}" :  $"min={number3}") : ((number2 < number3) ? $"min ={number2}" : $"min ={number3}");
            Console.WriteLine(answer);
        }
        enum HTTPError
        {
            Bad_Request = 400,
            Unauthorized = 401,
            Payment_Required = 402,
            Forbidden = 403,
            Not_Found = 404,
            Method_Not_Allowed = 405,
            Not_Acceptable = 406,
            Proxy_Authentication_Required = 407,
            Request_Timeout = 408,
            Conflict = 409,
            Gone = 410,
            Length_Required = 411,
            Precondition_Failed = 412,
            Payload_Too_Large = 413,
            URI_Too_Long = 414,
            Unsupported_Media_Type = 415,
            Range_Not_Satisfiable = 416,
            Expectation_Failed = 417,
            Misdirected_Request = 421,
            Unavailable_For_Legal_Reasons = 451
        }
        private static void Execes3()
        {
            Console.WriteLine("Enter the error number");
            int error = Convert.ToInt32(Console.ReadLine());
            HTTPError hTTPError = (HTTPError)error;
            {
                Console.WriteLine(hTTPError);
            }
        }
        struct Dog
        {
            public string name;
            public string mark;
            public int age;
            public override string ToString()
            {
                return string.Format($"The dog's name is {name}. The dog's mark is {mark}. The dog's age is {age}.");
            }
        }
            private static void Execes4()
            {
            Dog myDog;
            Console.WriteLine("what is your dog's name?");
            myDog.name = Console.ReadLine();
            Console.WriteLine("what mark is your dog");
            myDog.mark = Console.ReadLine();
            Console.WriteLine("how old is your dog?");
            myDog.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(myDog);
            Console.ReadLine();
            }
        }
    
}
