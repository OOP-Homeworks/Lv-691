using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW2
{
    internal class NumInRange
    {
        public void ChekNumIsInRange(params float[] nums)
        {
            foreach (var item in nums)
            {
                if (item < -5.0 || item > 5.0)
                {
                    Console.WriteLine($"This number {item} is not in the range - 5 to 5");
                    Thread.Sleep(2000);
                    return;
                }
            }
            Console.WriteLine("All numbers are in the range - 5 to 5");

        }
    }
}
