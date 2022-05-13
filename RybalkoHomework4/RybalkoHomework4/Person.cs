using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RybalkoHomework4
{
    class Person
    {
        private string name;
        private DateTime data;
        private int age;
        public string Name
        {
            get { return name; }
            set {}
        }
        public DateTime Data
        {
            get { return data; }
            set {}
        }
        public int Age
        {
            get {return age;}
            set { }
        }
        public Person()
        {
            name = "Voland";
            data = new DateTime(1999, 04, 12);
        }
        public Person(string name, DateTime data)
        {
            this.name = name;
            this.data = data;
        }
        public void AgeX ()
        {
            int age = ((DateTime.Today.Year) - (data.Year));
            this.age = age;
        }
        public static Person Input(int x)
        {
            Console.Write($"Enter {x + 1} person name ");
            string name = Console.ReadLine();
            Console.Write($"Enter {x + 1} person dayof birth ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter {x + 1} person month of birth ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter {x + 1} person year of birth ");
            int year = Convert.ToInt32(Console.ReadLine());
            DateTime data = new DateTime(year, month, day);
            Person person = new Person(name, data);
            return person;
        }
        public void ChangeName(string x)
        {
            name = x;
        }
        public static bool operator == (Person first, Person second)
        {
            return (first.name == second.name);
        }
        public static bool operator != (Person first, Person second)
        {
            return !(first.name == second.name);
        }
        public void ToString()
        {
            Console.WriteLine($"Name - {name}. The birthday year - {age}");
        }
        public void OutPut()
        {
            ToString();
        }

    }
}
