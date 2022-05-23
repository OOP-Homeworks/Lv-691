using System;
using System.Collections.Generic;
using System.Text;

namespace hw8_osypov
{
    class Square : Shape
    {
        private double Side;

        public Square(string name, double side) : base(name)
        {
            Side = side;
        }
        public override double Area()
        {
            return (Math.Pow(Side, 2));
        }
        public override double Perimeter()
        {
            return (4 * Side);
        }
    }
}
