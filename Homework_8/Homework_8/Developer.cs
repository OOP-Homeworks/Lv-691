using System;
namespace Homework_8
{
    public class Developer: Staff
    {
        private string language;

        public Developer(string name, string surname, string language,int salary): base(name, surname, salary)
        {
            this.language = language;
        }
        public override void Print()
        {
            base.Print();
        }
    }
}
