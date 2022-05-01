using System;

namespace Task2
{
    internal class Tsk2
    {
        private void monthOrDay(int num)
        {
            if (num > 0 && num <= 12)
            {
                Console.WriteLine($"Your number {num} can be month and can be day too");
            }
            else if (num > 0 && num <= 31)
            {
                Console.WriteLine($"Your number {num} can be only day");
            }
        }

        public void IsNumMonthOrday()
        {
            Console.WriteLine($"Please enter two numbers one by one");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            int secondNum = Convert.ToInt32(Console.ReadLine());
            monthOrDay(firstNum);
            monthOrDay(secondNum);
        }

        public void GetSumFirstTwoNumAfterPoint()
        {
            Console.WriteLine($"number like 3.456 or 77.8788");
            double num = Convert.ToDouble(Console.ReadLine());


            //изменила решение, т.к. при использовании ниже указанной формулы
            //происходит усечение введенного числа до вычислений.
            //Т.е.введенное число double сначала приведется к int затем проводятся вычисления,
            //а т.к. это число double то произойдет усечение и мы получим не тот результат, что ожидаем.
            //Число double просто не поместится в int , т.е. при введении
            //123456789012,456456456456 получим неожиданный результат из-за усечения.
            //Поэтому сначала делаю необходимое мне преобразование не изменяя тип числа,
            //а потом с полученным искомым числом совершаю вычисления            

            //int desiredVal = (int)(num * 100) % 100;
            //Console.WriteLine($"desiredVal is {desiredVal}");
            
            double desiredVal = (num * 100) % 100;
            int result = (int)desiredVal / 10 + (int)desiredVal % 10;
            Console.WriteLine($"Result is {result}");
        }

        public void GreetingDependOnTime()
        {
            Console.WriteLine($"Please enter in 24 hour format (hh:mm), like 23:55 or 01:35 or 00:00");
            int hour = Convert.ToInt32(Console.ReadLine().Substring(0, 2));
            string greeting = ((hour >= 5) && (hour < 12)) ? "Good morning" :
                (((hour >= 12) && (hour < 17)) ? "Good afternoon" :
                (((hour >= 17) && (hour < 22)) ? "Good evening" :
                ((((hour >= 22) && (hour < 24)) || ((hour >= 0) && (hour < 5))) ? "Good night" : "Please enter in 24 hour format, like 11:15 or 21:00")));
            Console.WriteLine(greeting);
        }



        static void Main(string[] args)
        {
            Tsk2 obj = new();
            //obj.IsNumMonthOrday();
            //obj.GetSumFirstTwoNumAfterPoint();
            obj.GreetingDependOnTime();
        }
    }
}

