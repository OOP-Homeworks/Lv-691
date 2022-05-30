using System;
using System.Collections.Generic;
using System.Text;

namespace hw10
{
    public struct Point
    {
        private int x;
        private int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
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
        public string ToString()
        {
            return ($"({x},{y})");
        }
        public double Distance(Point other)
        {
            double res;
            res = Math.Sqrt(Math.Pow((x - other.X), 2) + Math.Pow((y - other.Y), 2));
            return res;
        }
    }
}
