using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalaOks_HW1
{
    internal class Circle
    {
        public double Radius { get; set; }
        public double Lenth { get; set; }
        public double Area { get; set; }
        public double Volume { get; set; }
        public void GetLenth()
        {
            Lenth = 2 * Radius * Math.PI;
        }
        public void GetArea()
        {
            Area = Radius * Radius * Math.PI;
        }
        public void GetVolume()
        {
            Volume = 4 / 3 * Radius * Radius * Radius * Math.PI;
        }

        public void Print()
        {
            Console.WriteLine($"Lenth: {Lenth}, /n Area: {Area} and /n Volume {Volume}");
        }
    }
}
