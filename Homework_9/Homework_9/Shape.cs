using System;
namespace Homework_9
{
    public abstract class Shape : IComparable<Shape>
    {
        private string name;

        public Shape(string name)
        {
            this.name = name;
        }

        public virtual string Name()
        { return name; }
        public abstract double Name { get; }

        public abstract double Perimeter();

        public int CompareTo(Shape other)
        {
            if (other == null) return 1;
            else
                return this.Name().CompareTo(other.Name());
        }

        internal int Area()
        {
            throw new NotImplementedException();
        }

        internal string Name()
        {
            throw new NotImplementedException();
        }
    }
}