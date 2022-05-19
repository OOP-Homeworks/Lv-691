using System;
using System.Collections.Generic;
using System.IO;

namespace MalaOks_HW7_tsk7
{
    internal class Program
    {
        private void CopyDataStreamReaderWriter()
        {
            try
            {
                string fileName = "D:\\Data1.txt";
                StreamReader reader = new(fileName);
                string text1 = reader.ReadToEnd();
                reader.Close();
                StreamWriter writer = new("D:\\Rezult1.txt");
                writer.WriteLine(text1);
                writer.Close();
                Console.WriteLine($"Data from {fileName} was copy to D:\\Rezult1.txt");

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CopyDataFileReadWrite()
        {
            try
            {
                string file1 = "D:\\Data2.txt";
                string file2 = "D:\\Result2.txt";
                string text2 = File.ReadAllText(file1);
                File.WriteAllText(file2, text2);
                Console.WriteLine($"Data from {file1} was copy to {file2}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void InfoAboutFilesDiscD()
        {
            try
            {
                string path = @"D:\";
                string pathWrite = @"D:\\Info.txt";
                DirectoryInfo di = new(path);
                FileInfo[] fi = di.GetFiles();
                foreach (FileInfo f in fi)
                {
                    using (StreamWriter sw = new(pathWrite, true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(f.Name);
                        sw.WriteLine(f.CreationTime);
                        sw.WriteLine(f.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void FindTXTFilesDiscD()
        {
            try
            {
                string path = @"D:\";
                DirectoryInfo di = new(path);
                FileInfo[] fi = di.GetFiles();
                foreach (FileInfo f in fi)
                {
                    if (f.Extension == ".txt")
                    {
                        using (StreamReader sr = new(f.FullName, System.Text.Encoding.Default))
                        {
                            Console.WriteLine(f.Name + " content:");
                            Console.WriteLine(sr.ReadToEnd());
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void FillDictFromFile(Dictionary<string, string> dict, string path)
        {
            try
            {
                string line = String.Empty;
                using (StreamReader sr = new(path, System.Text.Encoding.Default))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] str = line.Split(" ");
                        dict.Add(str[0], str[1]);

                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void PrintDict(Dictionary<string, string> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }

        private void WritePhonesIntoFile(Dictionary<string, string> dict, string path)
        {
            try
            {
                using (StreamWriter sw = new(path, true, System.Text.Encoding.Default))
                {
                    foreach (var item in dict)
                    {
                        sw.WriteLine(item.Value);
                    }
                }

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private string FindValueByKey(Dictionary<string, string> dict, string key)
        {
            string rez = String.Empty;
            foreach (var item in dict)
            {
                if (item.Key.ToLower() == key.ToLower())
                {
                    rez = item.Value;
                }
            }
            return rez;
        }




        private void ChangeValByKeyDict(Dictionary<string, string> dict, string key, string val)
        {
            dict[key] = val;
        }

        private void ChangeFormatValueDict(Dictionary<string, string> dict)
        {
            try
            {
                string myKey = String.Empty;
                string myNewVal = String.Empty;
                foreach (var item in dict)
                {
                    if (item.Value.StartsWith('8'))
                    {
                        myKey = item.Key;
                        myNewVal = item.Value.Insert(0, "+3");
                        ChangeValByKeyDict(dict, myKey, myNewVal);
                    }
                    else if (item.Value.StartsWith('0'))
                    {
                        myKey = item.Key;
                        myNewVal = item.Value.Insert(0, "+38");
                        ChangeValByKeyDict(dict, myKey, myNewVal);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void WriteContentDictIntoFile(Dictionary<string, string> dict, string path)
        {
            try
            {
                using (StreamWriter sw = new(path, true, System.Text.Encoding.Default))
                {
                    foreach (var item in dict)
                    {
                        sw.WriteLine(item.Key + " " + item.Value);
                    }
                }

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("Streamreader");
            obj.CopyDataStreamReaderWriter();

            Console.WriteLine("File.Read/Write");
            obj.CopyDataFileReadWrite();

            Console.WriteLine("Write info about file in disc D");
            obj.InfoAboutFilesDiscD();

            Console.WriteLine("Finding .txt files in disc D and print content");
            obj.FindTXTFilesDiscD();

            Console.WriteLine("Dictionary");
            Dictionary<string, string> phoneBook = new();
            string path = @"D:\NamePhones.txt";
            obj.FillDictFromFile(phoneBook, path);
            Console.WriteLine("Sourсe dictionary");
            obj.PrintDict(phoneBook);

            string filePhNumbers = @"D:\Phones.txt";
            obj.WritePhonesIntoFile(phoneBook, filePhNumbers);
            Console.WriteLine("Enter a name to get a phone number");
            string name = Console.ReadLine();
            Console.WriteLine(obj.FindValueByKey(phoneBook, name));
            Console.WriteLine("Change format phone numbers to appropriate format");
            obj.ChangeFormatValueDict(phoneBook);
            string filePhNumbersChangeFormat = @"D:\NewFormatPhones.txt";
            obj.WriteContentDictIntoFile(phoneBook, filePhNumbersChangeFormat);
        }
    }
}
