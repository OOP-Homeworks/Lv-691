using System;
using System.Collections.Generic;
using System.Text;

namespace hw9_osypov
{
    abstract class Shape : IComparable<Shape>
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { Name = value; }
        }
        public Shape(string name)
        {
            this.name = name;
        }
        public int CompareTo(Shape obj) => (int)this.Area() - (int)obj.Area();
        public abstract double Area();
        public abstract double Perimeter();
    }
}
