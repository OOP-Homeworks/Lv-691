using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mala_HW4
{
    internal class Person
    {
        private DateTime birthYear;
        private string name;
        public DateTime BirthYear => birthYear;

        public string Name => name;

        public enum NameMonth
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,   
            December
        }
        public Person()
        {
            name = "Elen";
            birthYear = new DateTime(2000, 03, 15);
        }
        public Person(string nm, DateTime dt)
        {
            name = nm;
            birthYear = dt;
        }

        public int GetAge(DateTime date)
        {
            int age = (DateTime.Now.Date.Year - date.Year);
            return age;
        }

        public static Person Input()
        {
            Console.WriteLine("Enter name of the person");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the date of birth of the person in format 'dd-mm-yyyy'");
            DateTime.TryParse(Console.ReadLine(), out DateTime dt);
            return new Person(name, dt);
        }
        public void ChangeName(string newName)
        {
            this.name = newName;
        }
        public override string ToString()
        {
            return $"Name = {Name}; " +
                $"\n Date of birth = {birthYear.Day} {Enum.Parse(typeof(NameMonth),birthYear.Month.ToString())} {birthYear.Year}";
        }
        public void Output()
        {
            Console.WriteLine(ToString());
        }
        public static bool operator ==(Person p1, Person p2)
        {
            return (p1.Name == p2.Name);
        }
        public static bool operator !=(Person p1, Person p2)
        {
            return !(p1.Name == p2.Name);
        }

    }
}
