using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace osypov_hw7
{
    class Program
    {
        static void Main(string[] args)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            Console.WriteLine(projectDirectory);
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            using (StreamReader reader = new StreamReader(Path.Join(projectDirectory, "dictionary.txt"), System.Text.Encoding.Default))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    string[] personData = line.Split(' ');
                    PhoneBook.Add(personData[0], personData[1]);
                }
                reader.Close();
                using (StreamWriter writer = new StreamWriter(Path.Join(projectDirectory, "Phones.txt")))
                {
                    foreach (var x in PhoneBook)
                    {
                        writer.WriteLine(x.Key);
                    }
                }
                foreach (var x in PhoneBook)
                {
                    Console.WriteLine(x);
                }
                Console.WriteLine("Can you enter name of some person");
                string name = Convert.ToString(Console.ReadLine());
                string outText = "Can't find user by given name";
                foreach (var x in PhoneBook)
                {
                    if (x.Value == name)
                    {
                        outText = x.Key;
                        break;
                    }
                }
                Console.WriteLine(name + " phone number is " + outText);
                Console.ReadKey();
            }

            string writePath = Path.Join(projectDirectory, "New.txt");
            try
            {
                using(StreamWriter writer = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    foreach(var x in PhoneBook)
                    {
                        if (!x.Key.StartsWith("+3"))
                        {
                            writer.WriteLine("+3" + x.Key + " " + x.Value); 
                        } 
                        else
                        {
                            writer.WriteLine(x.Key + " " + x.Value);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }   
    }
}