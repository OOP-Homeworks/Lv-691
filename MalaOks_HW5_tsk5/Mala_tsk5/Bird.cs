using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mala_tsk5
{
    internal class Bird : IFlyable
    {
        private string name;
        private bool canFly;

        public Bird(string v1, bool v2)
        {
            this.name = v1;
            this.canFly = v2;
        }

        public void Fly()
        {
            Console.WriteLine($"Bird {name} can fly {canFly}");
        }
    }
}
