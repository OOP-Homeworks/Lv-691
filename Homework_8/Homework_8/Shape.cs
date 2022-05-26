using System;
namespace Homework_8
{
    public abstract class Shape : IComparable<Shape>
    {
        private string name;

        public Shape(string name)
        {
            this.name = name;
        }
        virtual public string Name { get { return name; } }

        public abstract double Area();
        public abstract double Perimeter();

        public int CompareTo(Shape other)
        {
            if (other == null) return 1;
            else
                return this.Area().CompareTo(other.Area());
        }
    }
}