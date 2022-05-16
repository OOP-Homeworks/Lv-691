using System;
using System.Collections.Generic;
using System.IO;

namespace hw7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            StreamReader reader = new StreamReader(@"C:\Users\Professional\source\repos\hw7\hw7\phones.txt",System.Text.Encoding.Default);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(' ');
                PhoneBook.Add(data[0], data[1]);
            }
            reader.Close();

            //1
            using (StreamWriter writer = new StreamWriter(@"C:\Users\Professional\source\repos\hw7\hw7\onlyPhonesNumbers.txt"))
            {
                foreach (var el in PhoneBook)
                {
                    writer.WriteLine(el.Value);
                }
            }

            //2
            search:
            Console.WriteLine("Who's phone number you want to find?");
            string find = Console.ReadLine();
            bool is_present = false;
            foreach(var el in PhoneBook)
            {
                if(el.Key==find)
                {
                    is_present = true;
                    Console.WriteLine($"{find}'s number is {el.Value} ");
                }
            }
            if(!is_present)
            {
                Console.WriteLine("This person's number doesn't exist in dataBase. Try again");
                goto search;
            }

            //3
            using (StreamWriter writer = new StreamWriter(@"C:\Users\Professional\source\repos\hw7\hw7\New.txt"))
            {
                foreach (var el in PhoneBook)
                {
                    writer.WriteLine("+38"+el.Value);
                }
            }
        }
    }
}
