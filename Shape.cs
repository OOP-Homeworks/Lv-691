using System;
using System.Collections.Generic;
using System.Text;

namespace hw8
{
    abstract class Shape : IComparable<Shape>
    {
        private string name;

        public Shape(string n)
        {
            name = n;
        }
        public string Name
        {
          get{return name;}
          set{name=value;}
        }
        public abstract double Area();

        public int CompareTo(Shape obj) => (int)this.Area() - (int)obj.Area();

        public abstract double Perimeter();
    }
}
