using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mala_tsk5
{
    internal class Plane : IFlyable
    {
        private string model;
        private int flyingHeight;

        public Plane(string v1, int v2)
        {
            this.model = v1;
            this.flyingHeight = v2;
        }

        public void Fly()
        {
            Console.WriteLine($"Plane {model} flying height {flyingHeight}");
        }
    }
}
