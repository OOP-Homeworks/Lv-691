using System;
using System.Collections.Generic;
using System.Text;

namespace hw4_osypov
{
    class Person
    {
        private System.DateTime birthYear;
        private string name;

        public string Name
        {
            get { return name; }
        }
        public System.DateTime BirthYear
        {
            get { return birthYear; }
        }
        public Person(string name, System.DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }
        public static Person Input(int i)
        {
            Console.Write($"Enter { i + 1 } person name ");
            string name = Console.ReadLine();
            Console.Write($"Enter { i + 1 } person the birthday year ");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            Person person = new Person(name, new DateTime(Convert.ToInt32(birthYear), 1, 1));
            return person;           
        }
        
        public int Age()
        {
            DateTime now = DateTime.Today;
            int age = now.Year - birthYear.Year;
            if (birthYear > now.AddYears(-age)) age--;
            return age;
        }
        public Person ChangeName()
        {
            if (this.Age() < 16)
            {
                this.name = "Very Young";
            }
            Person person = new Person(this.name, this.birthYear);
            return person;

        }
        public void Outputs()
        {
            Console.WriteLine(this.ToString());
        }


        public static bool operator == (Person first, Person second)
        {
            return (first.name == second.name); 
        }
        public static bool operator != (Person first, Person second)
        {
            return !(first.name == second.name);
        }
        public override string ToString()
        {
            return "Person name: " + name + "; Person age: " + this.Age();
        }


    }
}
