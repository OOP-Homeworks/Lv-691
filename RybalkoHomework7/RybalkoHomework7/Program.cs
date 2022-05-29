using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RybalkoHomework7
{
    internal class Program
    {
        private static void Main()
        {
            string line;
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            using (StreamReader phones = new StreamReader("C:\\Users\\wylf1\\source\\repos\\RybalkoHomework7\\phones.txt"))
            {
                while (!phones.EndOfStream)
                {
                    line = phones.ReadLine();
                    string[] words = line.Split('-');
                    phonebook.Add(words[0].ToLower(), words[1]);
                }
            }

            using (StreamWriter SW = new StreamWriter("C:\\Users\\wylf1\\source\\repos\\RybalkoHomework7\\phones.txt", true))
            {
                foreach (string c in phonebook.Values)
                {
                    SW.WriteLine(c);
                }
            }
            Console.WriteLine("Enter a name");
            String searchname = Console.ReadLine().ToLower();
            string value;
            if (phonebook.TryGetValue(searchname, out value))
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("does not have this name!");
            }

            using (StreamWriter SW = new StreamWriter("C:\\Users\\wylf1\\source\\repos\\RybalkoHomework7\\New.txt", true))
            {

                foreach (string c in phonebook.Values)
                {
                    if (c.StartsWith("80"))
                    {
                        SW.WriteLine("+3" + c);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
