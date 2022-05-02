using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class FindMinMax
    {        
        public void MinMax(params int[] nums)
        {
            int min = nums[0];
            int max = nums[0];
            foreach (int num in nums)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine($"Min: {min}, Max: {max}");
        }
    }
}
