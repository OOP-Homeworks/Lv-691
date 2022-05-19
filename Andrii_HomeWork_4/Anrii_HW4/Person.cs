using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anrii_HW4
{
    class Person
    {
        int birthYear;
        string name;
        public string Name
        {
            get { return name; }
        }
        int BirthYear { get; }
        public Person()
        {


        }
        public Person(int birthYear, string name)
        {
            this.birthYear = birthYear;
            this.name = name;
        }

        public Person Input(int i)
        {
            Console.WriteLine($"Enter the person's name: #{++i}");
            name = Console.ReadLine();
            Console.WriteLine($"Enter birthday for {name}");
            birthYear = Convert.ToInt32(Console.ReadLine());

            Person person = new Person(birthYear, name);
            return person;

        }
        public int Age()
        {
            return DateTime.Now.Year - birthYear;

        }
        
        public string Output()
        {

            return $"Name {name}. birthYear {birthYear}";

        }
        public void ChangeName(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"Name: {name}, BirthYear: {birthYear}";
        }
        public static bool operator ==(Person obj1, Person obj2)
        {
            if ((object)obj1 == null || (object)obj2 == null)
            {
                return false;
            }
            if (obj1.GetType() != obj2.GetType())
            {
                return false;
            }
            return obj1.name == obj2.Name;
        }
        public static bool operator !=(Person obj1, Person obj2)
        {
            return !(obj1 == obj2);
        }

    }
}
