using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mala_HW5
{
    internal class Builder : IDeveloper, IComparable<IDeveloper>
    {
        //в связи с тем что название поля и свойства совпадают не вижу смысла отдельно описывать поле
        //буду использовать автоматической свойство
        //private string tool;
        public string Tool { get; set;}

        public List<int> SomethingBuilt = new();
        public Builder(string instrument)
        {
            Tool = instrument;  
        }
        //public List<int> SomethingBuilt { get; set; }
        public void Create()
        {
            int num = SomethingBuilt.Count;    
            Console.WriteLine("Builder create something");
            SomethingBuilt.Add(++num);
        }
        public void Destroy()
        {
            //поставлю в блок try catch, т.к. RemoveAt выкидывает исключение,
            //а индекс который я ему передаю вычисляемый и это небезопасно
            //хотя тут явно все будет ок, но по формальному признаку помещаю в try catch
            try
            {
                SomethingBuilt.RemoveAt(SomethingBuilt.Count - 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Index incorrectly calculated");
            }
            Console.WriteLine($"The last created object is destroyed. \n The total amount of built:{SomethingBuilt.Count}");
        }

        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);   
        }
    }
    
}
