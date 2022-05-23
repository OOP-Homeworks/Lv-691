using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalaOks_tsk8
{
    internal class Staff : Person, IComparable<Staff>
    {
        private int salary;
        public Staff(string nm, string srnm, int slr) : base(nm, srnm)
        {
            salary = slr;
        }
        public int Salary { get => salary; }
        override public string Name { get { return base.Name + " staff"; } }
        override public void Print()
        {
            Console.WriteLine($"Person: {Name} {SurName} {salary}");
        }

        public int CompareTo(Staff st)
        {
            Staff dv = st as Developer;
            Staff tch = st as Teacher;
            if (dv != null)
            {
                return salary.CompareTo(dv.Salary);
            }
            if (tch != null)
            {
                return salary.CompareTo(tch.Salary);
            }
            else
            {
                throw new Exception("Unable to compare");
            }
        }
    }
}
