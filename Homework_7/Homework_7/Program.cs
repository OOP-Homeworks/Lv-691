using System;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Homework_7
{
    class Program
    {
        private static Stream readPath;

        static void Main(string[] args)
        {
            try
            {
                string fileName1 = "/ Users / chynchenkosvitlana / Desktop / File1.pages";
                string fileName2 = "/ Users / chynchenkosvitlana / Desktop / File2.pages";

                string text = File.ReadAllText(fileName1);
                File.WriteAllText(fileName2, text);

                Console.WriteLine("Data from file {0} was copied to {1}", fileName1, fileName2);
            }
            catch (FileNotFoundException exeption)
            {
                Console.WriteLine(exeption.Message);
            }
            catch(IOException IOEx)
            {
                Console.WriteLine(IOEx.Message);
            }
            finally
            {
                Console.ReadKey();
            }

            //or variant 2

            try
            {
                string fileName = "/ Users / chynchenkosvitlana / Desktop / File1.pages";
                StreamReader reader = new StreamReader(fileName);
                string text = reader.ReadToEnd();
                reader.Close();
                StreamWriter writer = new StreamWriter("/ Users / chynchenkosvitlana / Desktop / File2.pages");
                writer.WriteLine(text);
                writer.Close();
                Console.WriteLine("Data from file {0} was copied to / Users / chynchenkosvitlana / Desktop / File2.pages", fileName); 
            }
            catch (FileNotFoundException exeption)
            {
                Console.WriteLine(exeption.Message);
            }
            catch (IOException IOEx)
            {
                Console.WriteLine(IOEx.Message);
            }
            finally
            {
                Console.ReadKey();
            }

            //2

            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            string readPath = @"/ Users / chynchenkosvitlana / Desktop / File.pages";
            string writePath = @"/ Users / chynchenkosvitlana / Desktop / File1.pages";
            string newFile = @"/ Users / chynchenkosvitlana / Desktop / File2.pages";
            string str = "";
            try
            {
                using (StreamReader rd = new StreamReader(readPath, System.Text.Encoding.Default))
                {
                    while ((str = rd.ReadLine()) != null)
                    {
                        string[] input = str.Split(' ');
                        PhoneBook.Add(input[0], input[1]);
                    }
                }
                using (StreamWriter wr = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    foreach (string number in PhoneBook.Keys)
                    {
                        wr.WriteLine(number);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Enter the name: ");
            string input = Console.ReadLine();
            foreach (KeyValuePair<string, string> v in PhoneBook)
            {
                if (v.Key == input)
                {
                    Console.WriteLine(v.Value);

                }
            }
            using (StreamWriter wr = new StreamWriter(newFile, false, System.Text.Encoding.Default))
            {
                foreach (string phone in PhoneBook.Values)
                {
                    if (!phone.StartsWith("+3"))
                    {
                        wr.WriteLine(phone);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
