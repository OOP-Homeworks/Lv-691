using HW1;
using System;
using System.Linq;

namespace Homeworks
{
    public delegate void GetMarkDel(Student student);


        internal class Program
    {

               
        static void Main(string[] args)
        {
            Student student = new Student();
            Parent parent = new Parent();
            Accountancy accountancy = new Accountancy();

            GetMarkDel p = parent.OnMarkChange;
            GetMarkDel a = accountancy.PayingFellowship;

            student.MarkChange += p;
            student.MarkChange += a;

            student.AddMark(20);
            student.AddMark(30);
            student.AddMark(40);
            student.AddMark(90);


            Console.WriteLine($"Final score from Student Class:{student.marks.Sum()}");

            Console.ReadKey();

            

            
        }

       
    }
}
