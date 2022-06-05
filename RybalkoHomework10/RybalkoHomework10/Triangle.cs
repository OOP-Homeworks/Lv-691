using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RybalkoHomework10
{
    public class Triangle
    {
        private Point vertex1, vertex2, vertex3;
        public Point A { get { return vertex1; } set { vertex1 = value; } }
        public Point B { get { return vertex2; } set { vertex2 = value; } }
        public Point C { get { return vertex3; } set { vertex3 = value; } }
        public Triangle(Point a, Point b, Point c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public double Distant(Point first, Point another)
        {
            double xxx = (double)first.x - another.x;
            double yyy = (double)first.y - another.y;
            double distant = Math.Sqrt(Math.Pow(xxx, 2) + Math.Pow(yyy, 2));
            return distant;
        }
        public Double Perimeter()
        {
            Double P = Distant(A, B) + Distant(B, C) + Distant(C, A);
            return P;
        }
        public double Square()
        {
            double semiP = Perimeter() / 2;
            double S = Math.Sqrt(semiP * (semiP - Distant(A, B)) * (semiP - Distant(B, C)) * (semiP - Distant(C, A)));
            return S;
        }
        public void Print()
        {
            Console.WriteLine($"Distant: AB = {Distant(A, B)} BC = {Distant(B, C)} CA = {Distant(C, A)}\n " +
                $"P = {Perimeter()} S = {Square()}");
        }

    }
}
