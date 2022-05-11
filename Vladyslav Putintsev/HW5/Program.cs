using System;
using System.Collections.Generic;

namespace Homeworks
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            List<IDeveloper> developers = new List<IDeveloper>();
            developers.Add(new Builder("Autocad"));
            developers.Add(new Builder("MathLab"));
            developers.Add(new Builder("CorelDraw"));
            developers.Add(new Programmer("CSharp", "Notepad"));
            developers.Add(new Programmer("PHP", "PHP Tool"));
            developers.Add(new Programmer("VB", "Visual Studio"));

            foreach (IDeveloper developer in developers)
            {
                developer.Create();
                developer.Destroy();
            }

            developers.Sort();

            foreach (IDeveloper developer in developers)
            {
                developer.Create();
            }


            //Second part

            Dictionary<uint, string> persons=new Dictionary<uint, string>();

            for(int i=1;i<8;i++)
            {
                Console.WriteLine($"Enter ID of {i} person");
                uint id=Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine($"Enter Name of {i} person");
                persons.Add(id, Console.ReadLine());
            }
            Console.Clear();
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
