using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace hw5_osypov
{
    class Program
    {

        static void Main(string[] args)
        {
            List<IDeveloper> developers = new List<IDeveloper>();

            developers.Add(new Programmer("C#"));
            developers.Add(new Programmer("JavaScript"));
            developers.Add(new Builder("Screwdriver"));
            developers.Add(new Builder("Power drill"));

            foreach (IDeveloper developer in developers)
            {
                developer.Create();
                developer.Destroy();
            }
            Console.ReadKey();


            Dictionary<uint, string> persons = new Dictionary<uint, string>();
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Enter ID and people name:");
                uint id = (uint)Convert.ToInt32(Console.ReadLine());
                string name = Console.ReadLine();
                persons.Add(id, name);
            }
            foreach (KeyValuePair<uint, string> keyValue in persons)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.WriteLine("Can you enter id of some person");
            uint n = (uint)Convert.ToInt32(Console.ReadLine());
            string outText = "Can't find this ID";
            foreach (KeyValuePair<uint, string> id in persons)
            {
                if(id.Key == n)
                {
                    outText = id.Value;
                    break;
                }                
            }
            Console.WriteLine("Your person is" + outText);
            Console.ReadKey();
        }

    }
}
