using System;
namespace Homework_9
{
    public class Square : Shape
    {
        private double side;

        public double Side { get { return side; } }

        public override double Name => throw new NotImplementedException();

        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }

        public override double Name() => (side * side);

        public override double Perimeter()
        {
            return 4 * side;
        }
    }
}