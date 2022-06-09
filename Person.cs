using System;
using System.Xml.Serialization;

namespace hw4
{
    [Serializable]
    [XmlInclude(typeof(Person))]
    public class Person
    {
        string name;
        System.DateTime birthYear;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public System.DateTime BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }

        public Person()
        {
            name = "none";
            birthYear = new System.DateTime();
        }
        public Person(string name, System.DateTime data )
        {
            this.name = name;
            birthYear = data;

        }
        public Person(Person other)
        {
            this.name = other.name;
            this.birthYear = other.birthYear;
        }
        public override string ToString()
        {
            return string.Format($"Name: {name}\t\tbirthday year : {birthYear.Year}");
        }

       
    }
}

