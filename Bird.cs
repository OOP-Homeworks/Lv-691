using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5
{
    public class Bird: IFlyable
    {
        string name;
        bool canFly;

        public Bird(string name,bool canFly)
        {
            this.name = name;
            this.canFly = canFly;
        }

        public void Fly()
        {
            Console.WriteLine("Bird {0} can fly {1}", name, canFly);
        }
    }
}
