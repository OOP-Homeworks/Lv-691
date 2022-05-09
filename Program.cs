using System;
using System.Collections.Generic;

namespace hw5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> myList = new List<IDeveloper>();
            myList.Add(new Programmer("C#"));
            myList.Add(new Builder("Bolharka"));
            myList.Add(new Builder("Sokyra"));
            myList.Add(new Programmer("C++"));
            myList.Add(new Programmer("Python"));
            myList.Add(new Builder("Pylka"));
            myList.Sort();

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Dictionary<uint, string> myd=new Dictionary<uint, string>();
            for (int i=0; i<7; i++)
            {
                Console.WriteLine("Enter ID and people name:");
                uint id= (uint)Convert.ToInt32(Console.ReadLine());
                string name = Console.ReadLine();
                myd.Add(id, name);
            }

            Console.WriteLine("Enter ID to get people name:");
            uint k = (uint)Convert.ToInt32(Console.ReadLine());
            bool found = false;
            foreach (KeyValuePair<uint, string> el in myd)
            {
                if (el.Key == k)
                {
                    Console.WriteLine($"Name: {el.Value}");
                    found = true;
                }
            }
            try
            {
                if (!found) throw new ArgumentException("Element does not exits");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
