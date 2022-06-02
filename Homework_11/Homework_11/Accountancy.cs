using System;
using System.Linq;
using System.Xml.Linq;

namespace Homework_11
{
    public class Accountancy
    {
        private object marks;

        public string Name { get; private set; }

        public void PayingFellowship (int newMark)
        {
            marks.Add(newMark);
            if (marks.Average() < 90)
            {
                Console.WriteLine(Name + "stypendia won't be payed: (");
            }
            else
            {
                Console.WriteLine(Name + "stypendia will be payed!");
            }
        }

        internal void Stypendia(int f)
        {
            throw new NotImplementedException();
        }
    }

}

