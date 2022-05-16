using System;
using System.Collections.Generic;

namespace MalaOks_HW6_tsk6
{
    internal class Program
    {

        List<int> nums = new();
        List<double> lstDouble = new();

        List<int> lstrngNums = new();
        Stack<int> stkrngNums = new();

        private int Div(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }
        private double Div(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }

        private List<int> GetIntegersNumsFromUser()
        {
            try
            {
                nums.Clear();
                Console.WriteLine("Enter two integers");
                Console.WriteLine("First number = ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second number = ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                nums.Add(num1);
                nums.Add(num2);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("You have entered non-numeric characters. " + ex.Message);
                GetIntegersNumsFromUser();
            }
            return nums;
        }

        private List<double> GetDoubleNumsFromUser()
        {
            try
            {
                lstDouble.Clear();
                Console.WriteLine("Enter two integers");
                Console.WriteLine("First number = ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Second number = ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                lstDouble.Add(num1);
                lstDouble.Add(num2);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("You have entered non-numeric characters. " + ex.Message);
                GetDoubleNumsFromUser();
            }
            return lstDouble;
        }


        private void NumsInRange()
        {
            int currNm = 0;
            int lastEl = 0;

            while (currNm < nums[1])
            {
            a1:
                try
                {
                    try
                    {
                        Console.WriteLine($"Enter integer number in range [{nums[0]}, {nums[1]}]");
                        currNm = Convert.ToInt32(Console.ReadLine());

                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("You have entered non-numeric characters. " + ex.Message);
                        goto a1;
                    }

                    if (lstrngNums.Count == 0)
                    {
                        if (currNm != nums[0])
                        {
                            lastEl = currNm;
                            lstrngNums.Add(currNm);
                        }
                        else
                        {
                            Console.WriteLine($"Entered num must be bigger then limit {nums[0]}");
                            goto a1;
                        }
                    }
                    else if (lstrngNums.Count >= 1)
                    {
                        if (currNm == nums[1])
                        {
                            Console.WriteLine("You have riched limit");
                            return;
                        }
                        else if (currNm > lastEl)
                        {
                            lastEl = currNm;
                            lstrngNums.Add(currNm);
                        }
                        else
                        {
                            throw new ApplicationException("Current number must be less then limit and " +
                                "current number must be > previous number");
                        }
                    }
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto a1;
                }
            }
        }
        ///////////////Второй вариант - Использовала коллекцию Stack, т.к. удобно сравнивать последний добавленный элемент с текущим
        /////////////// и не пришлось создавать лишних переменных
        private void NumsInRange111()
        {
            int currNm = 0;
            while (currNm < nums[1])
            {
            a2:
                try
                {
                    try
                    {
                        Console.WriteLine($"Enter integer number in range [{nums[0]}, {nums[1]}]");
                        currNm = Convert.ToInt32(Console.ReadLine());

                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("You have entered non-numeric characters. " + ex.Message);
                        goto a2;
                    }

                    if (stkrngNums.Count == 0)
                    {
                        if (currNm != nums[0])
                        {
                            stkrngNums.Push(currNm);
                        }
                        else
                        {
                            Console.WriteLine($"Entered num must be bigger then limit {nums[0]}");
                            goto a2;
                        }

                    }
                    else if (stkrngNums.Count >= 1)
                    {
                        if (currNm == nums[1])
                        {
                            Console.WriteLine("You have riched limit");
                            return;
                        }
                        else if (currNm > stkrngNums.Peek())
                        {
                            stkrngNums.Push(currNm);
                        }
                        else
                        {
                            throw new ApplicationException("Current number must be less then limit and " +
                                "current number must be > previous number");
                        }

                    }
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto a2;
                }
            }
        }




        static void Main(string[] args)
        {
            Program obj = new();
        a:
            Console.WriteLine("Division 2 int nums");
            try
            {
                obj.nums = obj.GetIntegersNumsFromUser();
                if (obj.nums[0] < obj.nums[1])
                {
                    throw new ApplicationException("First number must be > Second number");
                }
                Console.WriteLine($"First:{obj.nums[0]} / second {obj.nums[1]} = {obj.Div(obj.nums[0], obj.nums[1])}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Division by zero." + ex.Message);
                goto a;
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
                goto a;
            }

        /////////////////////// Double

        b:
            Console.WriteLine("Division 2 double nums");
            try
            {
                obj.lstDouble = obj.GetDoubleNumsFromUser();
                if (obj.lstDouble[0] < obj.lstDouble[1])
                {
                    throw new ApplicationException("First number must be > Second number");
                }
                Console.WriteLine($"First:{obj.lstDouble[0]} / second {obj.lstDouble[1]} = {obj.Div(obj.lstDouble[0], obj.lstDouble[1])}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Division by zero." + ex.Message);
                goto b;
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
                goto b;
            }

            ///////////// Range nums
            Console.WriteLine("Get range of nums");
            obj.nums = obj.GetIntegersNumsFromUser();
            obj.NumsInRange();
            Console.WriteLine($"Collection in range[{obj.nums[0]}, {obj.nums[1]}] (using List)");
            foreach (var item in obj.lstrngNums)
            {
                Console.WriteLine(item);
            }

            obj.nums = obj.GetIntegersNumsFromUser();
            obj.NumsInRange111();
            Console.WriteLine($"Collection in range[{obj.nums[0]}, {obj.nums[1]}] (using Stack)");
            foreach (var item in obj.stkrngNums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
