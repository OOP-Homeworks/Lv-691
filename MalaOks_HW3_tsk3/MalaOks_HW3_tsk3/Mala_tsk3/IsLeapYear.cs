using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mala_tsk3
{
    internal class IsLeapYear
    {
        public bool IsLeap(int year)
        {
            //DateTime.IsLeapYear(year);
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
