using System;
namespace Homework_8
{
    public abstract class Person : IComparable
    {
        private string name;
        private string surname;

        public Person (string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        virtual public string Name { get { return name; } }
        virtual public string Surname { get { return surname; } }

        public virtual void Print()
        {
            Console.WriteLine("This is person {0} {1}", this.name, this.surname);
        }

        public virtual int CompareTo(object obj1)
        {
            Person p1 = obj1 as Person;
            if (p1 == null)
                throw new ArgumentException("Object is not a person");
            else
                return this.Name.ToLower().CompareTo(p1.Name.ToLower());
        }
    }
}
