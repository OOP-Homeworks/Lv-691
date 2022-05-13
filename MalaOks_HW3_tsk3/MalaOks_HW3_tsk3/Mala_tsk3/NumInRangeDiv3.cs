using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mala_task3
{
    internal class NumInRangeDiv3
    {
        int count = 0;
        public int Count
        {
            get
            {
                return count;
            }                        
            set
            {
                count = value;  
            }
        }

        public void FindNumDiv3(int start, int finish)
        {
            if (start > finish)
            {
                int temp = start;
                start = finish; 
                finish = temp;  
            }
            for (int i = start; i <= finish; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
        }
        public void Print ()
        {
            Console.WriteLine($"The number of numbers divisible by 3 without a remainder in the specified range: {Count}");
        }
    }
}
