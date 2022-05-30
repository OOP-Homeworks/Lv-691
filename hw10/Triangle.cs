using System;
using System.Collections.Generic;
using System.Text;

namespace osypov_hw10
{
    public class Triangle
    {
        private Point vertex1, vertex2, vertex3;

        public Triangle(Point a, Point b, Point c)
        {
            vertex1 = a;
            vertex2 = b;
            vertex3 = c;
        }
        public bool Print()
        {
            bool r = true;
            r &= (this.vertex1.Distance(vertex2) + this.vertex2.Distance(vertex3)) > this.vertex3.Distance(vertex1);
            r &= (this.vertex1.Distance(vertex3) + this.vertex2.Distance(vertex3)) > this.vertex2.Distance(vertex1);
            r &= (this.vertex1.Distance(vertex2) + this.vertex1.Distance(vertex3)) > this.vertex2.Distance(vertex3);
            return r;
        }
        public double Perimeter()
        {
            if (!Print()) throw new ArgumentException();
            double a = this.vertex1.Distance(vertex2);
            double b = this.vertex2.Distance(vertex3);
            double c = this.vertex3.Distance(vertex1);
            return Math.Round(a + b + c);
        }
        public double Square()
        {
            if (!Print()) throw new ArgumentException();
            double a = this.vertex1.Distance(vertex2);
            double b = this.vertex2.Distance(vertex3);
            double c = this.vertex3.Distance(vertex1);
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
