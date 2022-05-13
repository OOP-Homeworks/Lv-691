using System;
using System.Collections.Generic;
using System.Text;


namespace hw5
{
    class Programmer: IDeveloper, IComparable<IDeveloper>
    {
        string language;
       public Programmer()
        {
            language = "none";
        }
        public Programmer(string l)
        {
            language = l;
        }
        public string Tool
        {
            get { return language; }
            set { language = value; }
        }
        void IDeveloper.Create()
        {
            Console.WriteLine($"Programmer created application on {language} programming language");
        }
        void IDeveloper.Destroy()
        {
            Console.WriteLine("Programmer have destroyed prodaction");
        }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }

    }
}
