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
        enum Drinck { TEA, COFFE, WATER }


        public void Taks1()
        {
            int[] arry = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32 };
            int result = 0;

            for (int i = 0; i < arry.Length; i++)
            {
                if ((arry[i] % 3) == 0)
                {
                    result++;
                }
            }
            Console.WriteLine(result);


        }
        public void Task2()
        {
            string userNumber = "123456789";

            for (int i = 0; i < userNumber.Length; i += 2)
            {
                Console.WriteLine(userNumber[i]);
            }
        }
        public void Task3()
        {
            string userValue = "tea";
            userValue = userValue.ToUpper();

            switch (userValue)
            {

                case "TEA":
                    Console.WriteLine("Price 1 UAH"); ;
                    break;
                case "JUICE":
                    Console.WriteLine("Price 2 UAH");
                    break;
                case "WATER":
                    Console.WriteLine("Price 3 UAH");
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
        public void Task4()
        {
            int userNumber = 0;
            int secondNumber = 0;
            int index = 0;
            while (true)
            {
                secondNumber += userNumber;
                userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber < 0)
                {
                    break;
                }
                index++;

            }
            Console.WriteLine(secondNumber / index);
        }
        public void Task5()
        {
            Console.WriteLine("Enter year:");
            int year = Convert.ToInt32(Console.ReadLine());

            static bool checkYear(int year)
            {
                if (year % 400 == 0)
                    return true;
                if (year % 100 == 0)
                    return false;
                if (year % 4 == 0)
                    return true;
                return false;
            }

            Console.Write(checkYear(year) ? "Leap Year" :
                                     "Not a Leap Year");


        }
        public void Task6And7()
        {
            int userNumber = 123456789;
            int result = 0;


            while (userNumber > 0)
            {

                int secondNumber = (userNumber % 10);
                result += userNumber % 10;
                if (secondNumber % 2 == 0)
                {
                    Console.WriteLine($"Even numbers: {secondNumber}");
                }
                userNumber = userNumber / 10;


            }

            Console.WriteLine(result);
        }
        public void HomeWork1()
        {
            //Calculate the counts of characters ‘a’, ’o’, ’i’, ’e’  in this text.
            string userValue = "ABCDEFGHIKLMNOPQRSTVXYZ";
            userValue.ToUpper();
            int result = 0;

            for (int i = 0; i < userValue.Length; i++)
            {
                if ((userValue[i] == 'A') || (userValue[i] == 'O') || (userValue[i] == 'I') || (userValue[i] == 'E'))
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
        public void HomeWork2()
        {
            Console.WriteLine("Enter month: ");
            int userMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter year:");
            int userYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(DateTime.DaysInMonth(userMonth, userYear));
        }
        public void HomeWork3()
        {
            const int LENGTH_ARRAY = 10;


            int[] array = new int[LENGTH_ARRAY] { 100, 200, 300, 400, 500, 600, 700, 800, 900, -1 };
            bool negativeNumbers = false;
            int result = 0;

            for (int i = 0; i < LENGTH_ARRAY; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

                negativeNumbers = array[i] < 0 ? true : false;

            }

            if (negativeNumbers == false)
            {
                for (int i = 0; i < 5; i++)
                {
                    result += array[i];
                }

            }
            else
            {
                for (int i = 9; i > 4; i++)
                {
                    result += array[i];
                }
            }
            Console.WriteLine(result);
        }

        static void Main()
        {
            
        }

    }


}
