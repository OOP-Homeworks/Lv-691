using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalaOks_HW3_tsk3
{
    internal class CalculateCharactersInStr
    {
        public int ContCharacters(string sourse)
        {
            int count = 0;
            string str = sourse.ToLower().Replace(" ", "");
            foreach (var item in str)
            {
                if (item == 'a' || item == 'o' || item == 'i' || item == 'e')
                {
                    count++;
                }

            }
            return count;   
        }
    }
}
