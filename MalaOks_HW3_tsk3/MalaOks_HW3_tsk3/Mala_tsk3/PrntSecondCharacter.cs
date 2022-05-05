using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mala_tsk3
{
    internal class PrntSecondCharacter
    {
        public void PrintSecondCharacterIStr(string str)
        {
            string arrStr = str.ToLower().Replace(" ", "");
            for (int i = 0; i < arrStr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(arrStr[i]);
                }
            }
        }
    }
}
