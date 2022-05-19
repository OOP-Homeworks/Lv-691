using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RybalkoHomework5
{
    internal class Program
    {
        private static void Main()
        {
            IDeveloper[] IDeveloper = new IDeveloper[4];
            IDeveloper[0] = new Builder()
            {
                Tool = "4"
            };
            IDeveloper[1] = new Builder()
            {
                Tool = "6"
            };
            IDeveloper[2] = new Programmer()
            {
                Tool = "1"
            };
            IDeveloper[3] = new Programmer()
            {
                Tool = "2"
            };
            foreach (IDeveloper x in IDeveloper)
            {
                x.Creat();
                x.Destroy();
            }
            List<IDeveloper> dev = new List<IDeveloper>();
            dev.Add(new Builder()
            {
                Tool = "3"
            });
            dev.Add(IDeveloper[1]);
            dev.Add(new Programmer()
            {
                Tool = "5"
            });
            dev.Add(IDeveloper[3]);
            foreach(IDeveloper y in dev)
            {
                y.Creat();
                y.Destroy();
                Console.WriteLine(y.Tool);
            }
            dev.Sort();
            Console.WriteLine();
            foreach (IDeveloper y in dev)
            {
                Console.WriteLine(y.Tool);
            }
        }
    }
}
