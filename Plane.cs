using System;
namespace Homework_5
{
    public class Plane: IFlyable
    {
        string mark;
        float highFly;

        public Plane(string mark, float highFly)
        {
            this.mark = mark;
            this.highFly = highFly;
        }

        public void Fly()
        {
            Console.WriteLine("Plane {0} can fly {1} m altitude", mark, highFly);
        }
    }
}
