using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    public struct Point
    {
        public int X, Y;

        public Point(int x,int y)
        {
            this.X = x; this.Y = y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public double Distance(Point p)
        {
            return Math.Sqrt((Math.Pow(this.X - p.X, 2) + Math.Pow(this.Y - p.Y, 2)));
        }
    }
    public class Triangle
    {
        Point v1, v2, v3;

        public Triangle(Point v1, Point v2, Point v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public double Perimeter()
        {
            double firstsecond = v1.Distance(v2);
            double secondthird= v2.Distance(v3);
            double thirdfirst=v3.Distance(v1);

            return Math.Round(firstsecond + secondthird + thirdfirst,2);
        }

        public double Square()
        {
            double firstsecond = v1.Distance(v2);
            double secondthird = v2.Distance(v3);
            double thirdfirst = v3.Distance(v1);
            double semiPerimeter = Perimeter() / 2;

            return Math.Round(Math.Sqrt(semiPerimeter*(semiPerimeter-firstsecond)*(semiPerimeter-secondthird)*(semiPerimeter-thirdfirst)),2);
        }

        public override string ToString()
        {
            return $"Vertex1={v1.ToString()} Vertex2={v2.ToString()} Vertex3={v3.ToString()} Perimeter={Perimeter()} Square={Square()}";
        }
    }
}
