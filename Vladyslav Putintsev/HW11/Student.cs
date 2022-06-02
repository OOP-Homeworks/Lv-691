using Homeworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    public  class Student
    {
        string name="Petro";
        public string Name { get { return name; } set { name = value; } }

        public List<int> marks = new List<int>();

        public event GetMarkDel MarkChange;

        public void AddMark(int newMark)
        {
            marks.Add(newMark);

            if(MarkChange != null)
            {
                MarkChange.Invoke(this);
            }

        }

    }
}
