using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mala_tsk3
{
    internal class AverSum
    {
        public void GetAveragePosNum()
        {
            int count = 0;
            int sum = 0;
            int num;

            Console.WriteLine("Enter numbers one by one positive or negative " +
                "and you can get average of entered positive numbers");
            while ((num = Convert.ToInt32(Console.ReadLine())) >= 0)
            {
                sum += num;
                count++;
            }
            Console.WriteLine($"Average value for entered positive numbers = {sum / count}");
        }
    }
}
