using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalaOks_tsk8
{
    internal abstract class Person : IComparable
    {
        private string name;
        public string surName;
        public Person(string nm, string srnm)
        {
            name = nm;
            surName = srnm;
        }
        public virtual string Name { get { return name; } }
        public virtual string SurName { get { return surName; } }

        public virtual void Print()
        {
            Console.WriteLine($"Person: {name} {surName} ");
        }

        public virtual int CompareTo(object obj)
        {
            Person p = obj as Person;
            if (p == null)
            {
                throw new ArgumentException("Not Person");
            }
            else
            {
                return this.Name.ToLower().CompareTo(p.Name.ToLower());
            }
        }
    }
}
