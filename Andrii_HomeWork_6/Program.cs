namespace ConsoleApp10
{
    internal class Program
    {
        public static void Divided()
        {
            Console.WriteLine("Enter number one");
            double userNumberOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number two");
            double userNumberTwo = Convert.ToDouble(Console.ReadLine());

            if (userNumberTwo == 0)
            {
                throw new DivideByZeroException();
            }
            Console.WriteLine($"Result: {userNumberOne} / {userNumberTwo} = {Div(userNumberOne, userNumberTwo)}");

            static double Div(double userNumberOne, double userNumberTwo)
            {
                return userNumberOne / userNumberTwo;
            }
        }

        public static void ReadNumber(int start, int end)
        {
            List<int> list = new List<int>();

            for (int i = start; i < end; i++)
            {
                Console.WriteLine("Enter Value");
                int tmpUservalue = Convert.ToInt32(Console.ReadLine());
                list.Add(tmpUservalue);
                if (tmpUservalue < list.Max())
                {
                    throw new ApplicationException("The array contains a value less than the user entered");
                }
            }

        }

        static void Main(string[] args)
        {
        LABLE_1:
            try
            {
                Console.WriteLine("What method are you going to call?." +
                    "\n Press 1 to call the method Divided. " +
                    "\n Press 2 to call the method ReadNumber");
                int choiceOfMethod = Convert.ToInt32(Console.ReadLine());
                Console.Clear();


                switch (choiceOfMethod)
                {
                    case 1:
                        Divided();
                        break;
                    case 2:
                        Console.WriteLine("Enter start value");
                        int startValue = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter end value");
                        int endValue = Convert.ToInt32(Console.ReadLine());
                        ReadNumber(startValue, endValue);
                        break;

                    default:
                        throw new ApplicationException("Incorect number, please try again");
                }

            }
            catch (DivideByZeroException item)
            {
                Console.WriteLine(item.Message);
                goto LABLE_1;

            }
            catch (FormatException item)
            {
                Console.WriteLine(item.Message);
                goto LABLE_1;

            }
            catch (ApplicationException item)
            {
                Console.WriteLine(item.Message);
                goto LABLE_1;

            }
        }
    }
}