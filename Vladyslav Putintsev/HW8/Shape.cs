using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    abstract class Shape : IComparable<Shape>
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Shape(string name)
        {
            this.name = name;
        }

        public abstract double Perimeter();
        public abstract double Area();

        public int CompareTo(Shape other)
        {
            if (other == null)
                return 1;
            else
                return this.Area().CompareTo(other.Area());
        }
    }
}
