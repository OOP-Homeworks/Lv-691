using System;


namespace Homeworks
{
    internal class Program
    {
        enum HTTPError
        {
            BadRequest=400,
            Unauthorized=401,
            PaymentRequired=402,
            Forbidden=403,
            NotFound=404,
        }
        struct Dog
        {
            public string name;
            public string mark;
            public int age;

            public override string ToString()
            {
                return String.Format("Name: {0}, Mark: {1}, Age: {2}",name,mark,age);
            }
        }
        static void Main(string[] args)
        {
            ///<summary>
            ///Read 3 float numbers and check if they are all in the range [-5.5].
            ///</summary>
            Console.WriteLine("Please enter first float");
            if (Int32.TryParse(Console.ReadLine(), out int f1))
            {
                Console.WriteLine("Please enter second float");
                if (Int32.TryParse(Console.ReadLine(), out int f2))
                {
                    Console.WriteLine("Please enter third float");
                    if (Int32.TryParse(Console.ReadLine(), out int f3))
                    {
                        bool inrange = (f1 < -5 || f1 > 5) ?
                            false : (f2 < -5 || f2 > 5) ?
                            false : (f3 < -5 || f3 > 5) ?
                            false : true;

                        if (inrange)
                        {
                            Console.WriteLine("All entered numbers are in the range [1,5]");
                        }
                        else
                        {
                            Console.WriteLine("Not all entered numbers are in the range [1,5]");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong value.");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong value.");
                }
            }
            else
            {
                Console.WriteLine("Wrong value.");
            }

            ///<summary>
            ///Read 3 integer numbers and output max and min of them.
            ///</summary>

            Console.WriteLine("Please enter first integer");
            if (Int32.TryParse(Console.ReadLine(), out int n1))
            {
                Console.WriteLine("Please enter second integer");
                if (Int32.TryParse(Console.ReadLine(), out int n2))
                {
                    Console.WriteLine("Please enter third integer");
                    if (Int32.TryParse(Console.ReadLine(), out int n3))
                    {
                        int max = (n1 > n2 && n1 > n3) ?
                            n1 : (n2 > n3) ? n2 : n3;

                        Console.WriteLine("Largest number among {0}, {1}, {2} is {3}", n1, n2, n3, max);
                    }
                    else
                    {
                        Console.WriteLine("Wrong value.");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong value.");
                }
            }
            else
            {
                Console.WriteLine("Wrong value.");
            }

            ///<summary>
            ///Read number of HTTP Error (400, 401,402, ...) and write the name of this error (Declare enum HTTPError)
            ///</summary>

            Console.WriteLine("Please enter HTTP error code");
            if (Int32.TryParse(Console.ReadLine(), out int http))
            {
                Console.WriteLine("The name of {0} error is {1}", http, (HTTPError)http);
            }
            else
            {
                Console.WriteLine("Wrong code.");
            }

            ///< summary >
            /// Declare struct Dog with fields name, mark, age.
            /// Declare object myDog of Dog type and read values for it.
            /// Output information on the console. (Override method ToString in struct)
            /// </summary>

            Dog dog;
            dog.name = "Zara";
            dog.mark = "Pug";
            dog.age = 3;

            Console.WriteLine(dog);

            Console.ReadKey();
        }
            
            
    }
}
