using System;
using System.Collections.Generic;
using System.Text;

namespace hw10
{
   public class Triangle
    {
        private Point vertex1;
        private Point vertex2;
        private Point vertex3;

        public Triangle(Point a, Point b, Point c)
        {
            vertex1 = a; 
            vertex2 = b;
            vertex3 = c;

        }
        public bool Exist()
        {
            //трикутник існує, якщо сума кожних двох сторін більше ніж третя сторона.
            bool res = true;
            res &= (this.vertex1.Distance(vertex2) + this.vertex2.Distance(vertex3)) > this.vertex3.Distance(vertex1);
            res &= (this.vertex1.Distance(vertex3) + this.vertex2.Distance(vertex3)) > this.vertex2.Distance(vertex1);
            res &= (this.vertex1.Distance(vertex2) + this.vertex1.Distance(vertex3)) > this.vertex2.Distance(vertex3);
            return res;
        }
        public double Perimeter()
        {
            if (!Exist()) throw new ArgumentException();
            double res = 0;
            res = this.vertex1.Distance(vertex2) + this.vertex2.Distance(vertex3) + this.vertex3.Distance(vertex1);
            return res;
        }
        public double Area()
        {
            if (!Exist()) throw new ArgumentException();
            double res;
            double a = this.vertex1.Distance(vertex2);
            double b = this.vertex2.Distance(vertex3);
            double c = this.vertex3.Distance(vertex1);
            double p=(a+b+c)/2;
            res = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return res;
        }
        
    }
}
