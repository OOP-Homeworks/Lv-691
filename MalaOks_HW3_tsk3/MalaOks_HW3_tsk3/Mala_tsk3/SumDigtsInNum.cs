using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mala_tsk3
{
    internal class SumDigtsInNum
    {
        public int SumDigits { get; set; }

        public void GetSumDigits(int num)
        {
            do
            {
                SumDigits += num % 10;
                num = num / 10;

            } while (num != 0);
        }
    }
}
