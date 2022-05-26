using System;
namespace Homework_8
{
    public class Staff: Person, IComparable<Staff>
    {
        private int salary;

        public Staff(string name, string surname, int salary): base(name, surname)
        {
            this.salary = salary;
        }

        public int Salary { get { return salary; } }

        override public string Name { get { return base.Name + "Staff"; } }

        public override void Print()
        {
            Console.WriteLine("Person {0}{1} has salary: {2}", Name, Surname, salary);
        }
        public int CompareTo(Staff p)
        {
            Staff d = p as Developer;
            Staff t = p as Teacher;
            if (d != null)
                return this.salary.CompareTo(d.salary);
            else if (t != null)
                return this.salary.CompareTo(t.salary);
            else
                throw new Exception("Unable to compare two objects");
        }
    }
}
