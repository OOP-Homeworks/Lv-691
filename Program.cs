using System;

namespace Homework1Chynchenko

{
    class Program
    {
        static void Main(string[] args)

        {
            int a, b;

            Console.WriteLine("Please, write A");

            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please, write B");

            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Sum of {a} + {b} is {a + b}");

            Console.WriteLine($"Sub of {a} - {b} is {a - b}");

            Console.WriteLine($"Mult of {a} * {b} is {a * b}");

            Console.WriteLine($"Div of {a} / {b} is {a / b}\n");



            Console.WriteLine("How are you?");

            string answer = (Console.ReadLine());

            Console.WriteLine($"You are {answer}\n");



            char first, second, third;

            Console.WriteLine("Write the first char, please.");

            first = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Write the second char, please.");

            second = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Write the third char, please.");

            third = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"You enter {first}, {second}, {third}.\n");



            int c, d;

            Console.WriteLine("Please, write a number.");

            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write one more number.");

            d = Convert.ToInt32(Console.ReadLine());

            if (c > 0 && d > 0)

            {
                Console.WriteLine("Both integers are positive.\n");

            }


            int a1;

            Console.WriteLine("Please, write a side of the square");

            a1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The area of the square is {a1 * a1}");

            Console.WriteLine($"Perimeter of the square is {2 * (a1 + a1)}\n");



            string name;
            int age;

            Console.WriteLine("What is your name?");

            name = Console.ReadLine();

            Console.WriteLine($"How old are you, {name} ?");

            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your name is {name}. You are {age} years old.\n");



            double r;

            Console.WriteLine("Please, write the radius of a circle.");

            r = Convert.ToDouble(Console.ReadLine());

            const double pi = 3.14;

            Console.WriteLine($"The lenth of a circle is {2 * pi * r}.");

            Console.WriteLine($"The area of a circle is {pi * r * r}.");

            Console.WriteLine($"The volume of a circle is {4 / 3 * pi * r * r * r}.\n");



            Console.ReadKey();


        }
    }
}





/*Define integer variables a and b.
   Read values a and b from the console and calculate: a+b, a-b, a*b, a/b.
Output results on the console.

Output question “How are you?“.
   Define string variable answer.
   Read value answer and output on the console: “You are(answer)".

Read 3 variables of char type.
   Write message: “You enter (first char), (second char), (3 char)”

Enter 2 integer numbers.
Check if they are both positive – use bool expression


 Define integer variable a (side of the square).
Read value from the console and calculate the area and perimeter of a square with length a.
Output results on the console.

Define string name and integer age.
Output question "What is your name?";
Read value name and output next question: "How old are you, (name)?".
Read value age and output whole information

Read double number r (radius of a circle).
Calculate the length (l=2*pi*r), area (S=pi*r*r), and volume (4/3*pi*r*r*r) of a circle.
*/



