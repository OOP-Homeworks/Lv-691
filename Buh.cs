using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace hw11
{
    class Buh:Student
    {
        public void Stypendia(int nm)
        {
            marks.Add(nm);
            if (marks.Average() >= 90) Console.WriteLine(Name + " will be payed!");
            else Console.WriteLine(Name + " won't be payed :(");
        }
    }
}
