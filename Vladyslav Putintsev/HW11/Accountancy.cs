using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    public class Accountancy :Student
    {
        public void PayingFellowship(Student student)
        {
           // marks.Add(mark);

            if(student.marks.Sum()>=80)
            {
                Console.WriteLine($"{Name} will have a scholarship. His total score is {student.marks.Sum()}");
            }
            else
            {
                Console.WriteLine($"{Name} won't have a scholarship. His total score is {student.marks.Sum()}");
            }
        }
    }
}
