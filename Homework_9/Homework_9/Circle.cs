using System;
namespace Homework_9
{
    public class Circle : Shape
    {
        private double radius;

        public double Radius { get { return radius; } }

        public override double Name => throw new NotImplementedException();

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public override double Name()
        {
            return Math.PI * (radius * radius);
        }

        public override double Perimeter()
        {
            return Math.PI * 2 * radius;
        }
    }
}