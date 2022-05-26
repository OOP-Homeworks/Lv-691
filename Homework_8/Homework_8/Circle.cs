﻿using System;
namespace Homework_8
{
    public class Circle: Shape
    {
        private double radius;

        public double Radius { get { return radius; } }
        
        public Circle(string name, double radius): base(name)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI*(radius*radius);
        }
        public override double Perimeter()
        {
            return Math.PI*2*radius;
        }
    }
}
