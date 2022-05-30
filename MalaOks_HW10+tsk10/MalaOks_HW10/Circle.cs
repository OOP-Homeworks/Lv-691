using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalaOks_HW10
{
    public class Circle : Shape
    {
        public Circle(double rd, string nm) : base(nm)
        {
            Radius = rd;
        }
        public double Radius { get; set; }
        public override double Perimeter { get; set; }
        public override double Area { get; set; }
        public override void GetArea()
        {
            Area = Math.Pow(Radius, 2) * Math.PI;
        }
        public override void GetPerimeter()
        {
            Perimeter = Radius * 2 * Math.PI;
        }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, area: {Area}, perimeter: {Perimeter}");
        }
    }
}
