using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalaOks_HW1
{
    internal class Square
    {
        private int a = 0;
        public int LenthSide
        {
            get { return a; }
            set { a = value; }
        }
        public int Area { get; set; }
        public int Perimeter { get; set; }
        public void GetArea(int a)
        {
            Area = a * a;
        }
        public void GetPerimeter(int a)
        {
            Perimeter = a * 4;
        }

        public void Print()
        {
            Console.WriteLine($"Area of the square: {Area} and perimeter: {Perimeter}");
        }
    }
}
