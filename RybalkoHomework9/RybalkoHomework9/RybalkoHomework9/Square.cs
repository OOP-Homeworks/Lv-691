using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RybalkoHomework9
{
    internal class Square : Shape
    {
        private int side;

        public int Side { get { return side; } set { side = value; } }
        public Square(string name, int side) : base(name)
        {
            this.Side = side;
            perimeter = Perimeter(Side);
            area = Area(Side);
        }
        public override double Perimeter(int Side)
        {
            this.side = Side;
            double P = 4 * Side;
            return P;
        }
        public override double Area(int Side)
        {
            this.side = Side;
            double S = Side * Side;
            return S;
        }
        public override void Print()
        {
            base.Print();
        }
    }
}
