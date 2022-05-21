using System;
using System.Collections.Generic;
using System.Text;

namespace hw8
{
    class Circle : Shape 
    {
        private double radius;

        public double Radius
            {
            get { return radius; }
            set { radius = value; }
            }
        public Circle(string n, double r) : base(n)
        {
            radius = r;
        }
        public override double Area() => Math.PI * radius * radius;
        public override double Perimeter() => 2 * Math.PI * radius;
    }
}
