using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalaOks_HW9
{
    internal class Square : Shape
    {
        public Square(double sd, string nm) : base(nm)
        {
            Side = sd;
        }
        public double Side { get; set; }
        public override double Perimeter { get; set; }
        public override double Area { get; set; }
        public override void GetArea()
        {
            Area = Math.Pow(Side, 2);
        }
        public override void GetPerimeter()
        {
            Perimeter = Side * 4;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, area: {Area}, perimeter: {Perimeter}");
        }
    }
}
