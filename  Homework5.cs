using System;
using System.Collections.Generic;

namespace Homework_5
{

    class Program
    {
        static void Main(string[] args)
        {
            List<IFlyable> flyables = new List<IFlyable>();

            flyables.Add(new Bird("eagle", true));

            IFlyable bird02 = new Bird("crow", false);
            flyables.Add(bird02);
            IFlyable plane01 = new Plane("Airbus", 10000);
            flyables.Add(plane01);
            IFlyable plane02 = new Plane("Boeind", 9500);
            flyables.Add(plane02);

            foreach(IFlyable flyable in flyables)
            {
                flyable.Fly();
            };

            //2
            List<int> myColl = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number: = ");
                myColl.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Without elements more then 20");
            for (int i = 0; i < myColl.Count; i++)
            {
                if (myColl[i] > 20)
                {
                    myColl.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine("Without elements more then 20");
            for (int i = 0; i < myColl.Count; i++)
            {
                Console.WriteLine(myColl[i]);
            }
            for(int i = 0; i < myColl.Count; i++)
            {
                if (myColl[i] == 10)
                {
                    Console.WriteLine("For variable 10 index = {0}", i + 1);
                }
            }
            Console.WriteLine("Insert elements 1, -3, -4 in position 2, 8, 5");
            myColl[2] = 1;
            myColl[8] = -3;
            myColl[5] = -4;
            for(int i = 0; i < myColl.Count; i++)
            {
                Console.WriteLine(myColl[i]);
            }

            myColl.Sort();

            //3

            List<IDeveloper> developers = new List<IDeveloper>();

            developers.Add(new Programmer("C#"));
            developers.Add(new Programmer("Phyton"));
            developers.Add(new Builder("Tiler"));
            developers.Add(new Programmer("Plasterer"));
             foreach (IDeveloper developer in developers)
            {
                developer.Create();
                developer.Destroy();
            }

            //4
            Dictionary<uint, string> persons = new Dictionary<uint, string>();
            for (int i=0; i<=7; i++)
            {
                Console.WriteLine("Enter id of person");
                uint id = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Enter name of person");
                persons.Add(id, Console.ReadLine());
            }
            Console.WriteLine("Enter ID");
            if(!persons.TryGetValue(Convert.ToUInt32(Console.ReadLine()), out string name))
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine(name);
            }

                Console.ReadKey();
        }
    }
}
