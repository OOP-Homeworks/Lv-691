using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class FindMinMax
    {
        //private bool Compare(int num1, int num2)
        //{
        //    if (num1 > num2)
        //    {
        //        true; 
        //    }
        //}
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
