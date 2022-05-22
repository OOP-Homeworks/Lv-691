using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalaOks_tsk8
{
    internal class Developer : Staff
    {
        private string level;
        public Developer(string nm, string srnm, string lvl, int slry) : base(nm, srnm, slry)
        {
            level = lvl;
        }
        override public void Print()
        {
            Console.WriteLine($"Developer {Name} {SurName} level: {level}  salary: {Salary}");
        }
    }
}
