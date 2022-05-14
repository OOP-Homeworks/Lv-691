using System;
namespace Homework_5
{
    public class Programmer: IDeveloper, IComparable<IDeveloper>
    {
        string language;
        public string Tool
        {
            get { return language; }
            set { language = value; }
        }

        public Programmer(string language)
        {
            this.language = language;
        }

        public void Create()
        {
            Console.WriteLine("Programmer can create a project using {0} language", language);
        }

        public void Destroy()
        {
            Console.WriteLine("Programmer can destroy programm");
        }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return string.Compare(this.Tool, other.Tool);
        }
    }
}
