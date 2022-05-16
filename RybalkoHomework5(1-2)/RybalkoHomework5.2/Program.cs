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
            Dictionary<uint, string> idpeopl = new Dictionary<uint, string>();
            for(uint x=0; x<7; x++)
            {
                Console.Write($"ID {x+1} =");
                uint id = Convert.ToUInt32(Console.ReadLine());
                Console.Write($"Name {x+1} =");
                idpeopl.Add(id, Console.ReadLine());
            }
            Console.Write("Enter the ID ");
            uint i = Convert.ToUInt32(Console.ReadLine());
            if (!idpeopl.ContainsKey(i))
            {
                Console.WriteLine("sorry, such id does not exist");
            }
                foreach (uint x in idpeopl.Keys)
            {
                if(i == x)
                {
                    Console.WriteLine(idpeopl[x]);
                }
            }
        }
    }
}