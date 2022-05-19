using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RybalkoHomework5
{
    internal class Programmer : IDeveloper, IComparable
    {
        private string language;
        public string Tool { get { return language; } set { language = value; } }
        public int CompareTo(object? o)
        {
            IDeveloper X = (IDeveloper)o;
            if (X != null)
            {
                return language.CompareTo(X.Tool);
            }
            else { return 0; }
        }

        public void Creat()
        {
            Console.WriteLine("Programmer, creat");
        }

        public void Destroy()
        {
            Console.WriteLine("Programmer, destroy");
        }
    }
}
