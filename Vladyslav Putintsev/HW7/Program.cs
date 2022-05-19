using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Homeworks
{  

    internal class Program
    {
        
        static void Main(string[] args)
        {
            var comparer = StringComparer.OrdinalIgnoreCase;
            Dictionary<string,string> phoneBook = new Dictionary<string,string>(comparer);

            try
            {
                using (StreamReader sr = new StreamReader(@"C:\D\phones.txt", System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] pair = line.Split(',');
                        try
                        {
                            phoneBook.Add(pair[0], pair[1]);
                        }
                        catch (Exception ex) //We have to catch a duplicate in key exception and continue import
                        {
                            Console.WriteLine(ex.Message);
                        }

                    }

                }
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            using (StreamWriter sw = new StreamWriter(@"C:\D\phonesOut.txt", false, System.Text.Encoding.Default))
            {
                foreach (KeyValuePair<string,string> pair in phoneBook)
                {
                    sw.WriteLine(pair.Value);
                }
            }

            //Change format
            foreach (var pair in phoneBook.ToList())
            {
                if (pair.Value.Substring(0, 2) == "80")
                {
                    phoneBook[pair.Key] = "+3" + pair.Value;
                }
            }
            // Write new file.
            using (StreamWriter sw = new StreamWriter(@"C:\D\New.txt", false, System.Text.Encoding.Default))
            {
                foreach (KeyValuePair<string, string> pair in phoneBook)
                {
                    sw.WriteLine(pair.Key+","+pair.Value);
                }
            }

            Console.WriteLine("Please enter name:");
            string name=Console.ReadLine();
            if(phoneBook.TryGetValue(name, out string phoneNumber))
            {
                Console.WriteLine("Phone: "+phoneNumber);
            }
            else
            {
                Console.WriteLine("Phone not found");
            }

            Console.ReadKey();

            

            
        }

       
    }
}
