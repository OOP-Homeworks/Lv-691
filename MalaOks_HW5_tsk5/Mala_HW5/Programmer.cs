using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mala_HW5
{
    internal class Programmer : IDeveloper, IComparable<IDeveloper>
    {
        private string language;
        public List<int> SomeApp = new();
        public string Tool
        {
            get
            {
                return language;
            }
            set
            {
                language = value;
            }
        }
        public Programmer(string lang)
        {
            Tool = lang;
        }
        //public List<int> SomeApp { get; set; }
        public void Create()
        {
            int num = SomeApp.Count;
            SomeApp.Add(++num);
            Console.WriteLine($"Programmer create some application. \n The total amount of appliications:{SomeApp.Count}");
        }
        public void Destroy()
        {
            //поставлю в блок try catch, т.к. RemoveAt выкидывает исключение,
            //а индекс который я ему передаю вычисляемый и это небезопасно
            //хотя тут явно все будет ок, но по формальному признаку помещаю в try catch
            try
            {
                SomeApp.RemoveAt(SomeApp.Count - 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Index incorrectly calculated");
            }
            Console.WriteLine($"The last created object is destroyed. \n The total amount of appliications:{SomeApp.Count}");
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}
