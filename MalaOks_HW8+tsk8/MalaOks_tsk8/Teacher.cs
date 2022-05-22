using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalaOks_tsk8
{
    internal class Teacher : Staff
    {
        private string subject;

        public Teacher(string name, string srnm, string sbjct, int salr) : base(name, srnm, salr)
        {
            subject = sbjct;
        }

        override public void Print()
        {
            Console.WriteLine($"Teacher {Name} {SurName} subject: {subject}  salary: {Salary}");
        }
    }
}
