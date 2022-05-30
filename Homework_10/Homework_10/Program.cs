using System;

namespace Homework_10
{
    public struct Point
    {
        public int x, y;

        public Point (int x, int y) { this.x = x; this.y = y; }

        public int X
        {
            set { x = value; }

            get { return x; }
        }

        public int Y
        {
            set { y = value; }

            get { return y; }
        }

        public string ToString() => ($"({x},{y})");

        public double Distance(Point p)
        {
            return Math.Sqrt((Math.Pow(this.x - p.x, 2) + Math.Pow(this.y - p.y, 2)));
        }
    }
    public class Triangle
    {
        private Point a, b, c;

        public Triangle(Point a, Point b, Point c)
        { this.a = a; this.b = b; this.c = c; }

        public double Perimeter()
        {
            double onetwo = a.Distance(a);
            double twothree = b.Distance(b);
            double threeone = c.Distance(c);

            return Math.Round(onetwo + twothree + threeone);
        }

        public double Square()
        {
            double onetwo = a.Distance(a);
            double twothree = b.Distance(b);
            double threeone = c.Distance(c);
            double semiPerimeter = Perimeter() / 2;

            return Math.Round(Math.Sqrt(semiPerimeter * (semiPerimeter - onetwo) * (semiPerimeter - twothree) * (semiPerimeter - threeone)));
        }

        public bool Exist()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Vertex 1: {a.ToString()}, vertex 2: {b.ToString()}, vertex 3: {c.ToString()}, perimeter {Perimeter()}, square {Square()}";
        }

            static void Main(string[] args)
        {
            Point p1, p2, p3;
            p1 = new Point(1, 5);
            p2 = new Point(4, 1);
            p3 = new Point(1, 1);
            Triangle tr1 = new Triangle(p1, p2, p3);

            Console.ReadKey();
        }
    }
}
