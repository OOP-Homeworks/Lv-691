using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalaOks_Tsk10
{
    public struct MyPoint
    {
        public int x, y;
        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double Distance(MyPoint p)
        {
            return Math.Sqrt(Math.Pow((p.x - this.x), 2) + Math.Pow((p.y - this.y), 2));
        }
    }
    public class MyTriangle
    {

        private MyPoint p1, p2, p3;

        //side of a triangle
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double Perimeter { get; set; }
        public int Square { get; set; }
        public MyTriangle(MyPoint a, MyPoint b, MyPoint c)
        {
            p1 = a;
            p2 = b;
            p3 = c;
        }
        public void GetPerimeter(MyPoint p1, MyPoint p2, MyPoint p3)
        {
            try
            {
                A = p1.Distance(p2);
                B = p2.Distance(p3);
                C = p3.Distance(p1);
                Perimeter = A + B + C;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void GetSquare(MyPoint p1, MyPoint p2, MyPoint p3)
        {
            try
            {
                GetPerimeter(p1, p2, p3);
                double p = Perimeter / 2;
                Square = Convert.ToInt32(Math.Sqrt(p * (p - A) * (p - B) * (p - C)));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
