using System;
using System.Collections.Generic;
using System.Text;

namespace hw8_osypov
{
    class Circle : Shape
    {
        private double Radius;

        public Circle(string n, double radius) : base(n)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
