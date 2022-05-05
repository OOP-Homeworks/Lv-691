using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalaOks_HW3_tsk3
{
    internal class CountDaysInMonth
    {
        public int DaysInMonth(int year, int mnth)
        {
            //int days = DateTime.DaysInMonth(year, mnth);
            int days;
            switch (mnth)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                case 2:
                    if (DateTime.IsLeapYear(year))
                    {
                        days = 29;
                    }
                    else
                    {
                        days = 28;
                    }
                    break;
                default:
                    return 0;
            }
            return days;
        }
    }
}
