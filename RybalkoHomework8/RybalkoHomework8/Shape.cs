using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RybalkoHomework8
{
    public abstract class Shape : IComparable
    {
        private string name;
        public double perimeter { get; set; }
        public double area { get; set; }
        public Shape(string name)
        {
            this.Name = name;
        }
        virtual public string Name { get { return name; } set { name = value; } }

        public abstract double Area(int x);
        public abstract double Perimeter(int y);
        public virtual void Print()
        {
            Console.WriteLine($"Name - {name} P = {perimeter}, S = {area}");
        }

        public int CompareTo(object? obj)
        {
            return area.CompareTo(((Shape)obj).area);
        }
    }
}
