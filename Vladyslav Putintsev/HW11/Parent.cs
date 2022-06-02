using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    public  class Parent :Student
    {
        public void OnMarkChange(Student student)
        {
            Console.WriteLine($"{Name} has new Mark: {student.marks.Last()}");
        }
    }
}
