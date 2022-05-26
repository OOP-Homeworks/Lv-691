using System;
namespace Homework_8
{
    public class Teacher: Staff
    {
        private string subject;

        public Teacher(string name, string surname, string subject, int salary): base(name, surname, salary)
        {
            this.subject = subject;
        }
        public override void Print()
        {
            Console.WriteLine("Teacher {0} {1} is a teacher {2} with salary {3}", Name, Surname, subject, Salary);
        }
    }
}
