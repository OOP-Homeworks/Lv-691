using System;
using System.Collections.Generic;
using System.Text;

namespace hw8
{
    class Square:Shape
    {
        private double side;
        public double Side
        {
            get { return side; }
            set { side = value; }
        }
        public Square(string n,double s ):base(n)
        {
            side = s;
        }
        public override double Area() => side*side;
        public override double Perimeter() => 4*side;

    }
}
