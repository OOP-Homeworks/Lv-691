using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RybalkoHomework8
{
    internal class Circle: Shape
    {
        private int radius;

        public int R { get { return radius; } set { radius = value; } }
        public Circle(string name, int radius) : base(name)
        {
            this.R = radius;
            perimeter = Perimeter(radius);
            area = Area(radius);
        }
        public override double Perimeter(int R)
        {
            this.R = R;
            double P = 2 * R * Math.PI;
            return P;
        }
        public override double Area(int R)
        {
            this.R = R;
            double S = Math.PI * Math.Pow(R,2);
            return S;
        }
        public override void Print()
        {
            base.Print();
        }
    }
}
