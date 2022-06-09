using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RybalkoHomework10
{
    public struct Point
    {
        private int X, Y;
        public int x { get { return X; } set { X = value; } }
        public int y { get { return Y; } set { Y = value; } }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public string ToString()
        {
            return ($"({x},{y})");
        }
    }
}
