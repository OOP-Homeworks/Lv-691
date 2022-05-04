using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mala_tsk3
{
    internal class OnlyOddDigInNum
    {      
        public bool IsAllDigitsInNumOdd(int sourse)
        {
            bool res;
            do
            {
                if ((sourse % 10) % 2 != 0)
                {
                    res = true;
                }
                else
                {
                    res = false;
                    break;
                }
                sourse /= 10;

            } while (sourse != 0);
            return res;
        }
    }
}
