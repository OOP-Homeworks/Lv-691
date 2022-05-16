using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RybalkoHomework5
{
    internal class Builder : IDeveloper, IComparable
    {
        private string tool;
        public string Tool { get { return tool; } set { tool = value; } }

        public int CompareTo(object? o)
        {
            IDeveloper X = (IDeveloper)o;
            if(X != null)
            {
                return tool.CompareTo(X.Tool);
            }
            else { return 0; }
        }

        public void Creat()
        {
            Console.WriteLine("Builders, creat");
        }

        public void Destroy()
        {
            Console.WriteLine("Builders, destroy");
        }
    }
}
