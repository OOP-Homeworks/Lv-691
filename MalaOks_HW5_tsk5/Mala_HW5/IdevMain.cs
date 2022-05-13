using System;
using System.Collections.Generic;

namespace Mala_HW5
{
    internal class IdevMain
    {
        List<IDeveloper> lstDev = new List<IDeveloper>();
        public IdevMain()
        {
            lstDev.Add(new Programmer ("C#"));
            lstDev.Add(new Programmer("C++"));
            lstDev.Add(new Builder("Saw"));
            lstDev.Add(new Builder("Concrete mixer"));
        }


        ///////////////////////////////////////////////////////////////////
        private Dictionary<uint, string> dict = new Dictionary<uint, string>();
        private uint Id = 0;
        private void AddPersonToDict()
        {
            int num = 3;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter Name");
                dict.Add(++Id, Console.ReadLine());
            }            
        }

        private void FindNameInDictById(uint id)
        {
            //если не сделать эту переменную и в блоке if поставить else
            //то будем на каждой итерации видеть то что напишем в else
            //а так после всех итераций я определяю нашли или нет
            bool found = false;
            foreach (var kvp in dict) 
            {
                if (kvp.Key == id)
                {
                    Console.WriteLine($"By entered id person name is: {kvp.Value}");
                    found = true;
                }                
            }
            if (!found)
            {
                Console.WriteLine("By entered id no person was found");
            }
        }

        static void Main(string[] args)
        {
            IdevMain obj = new IdevMain();
            //вызовется два раза Create() для первого програмера, потом item.Destroy(),
            //потом два раза у второго програмера и один дестрой, потом два раза у первого билдера т.п.
            foreach (var item in obj.lstDev)
            {
                item.Create();
                item.Create();
                item.Destroy();
            }

            //отсортировал по значению свойства и переставил местами у билдера
            obj.lstDev.Sort();
            foreach (var item in obj.lstDev)
            {
                Console.WriteLine(item.Tool);
            }

            //Dictionary
            obj.AddPersonToDict();

            Console.WriteLine("Enter id to find name of person");
            uint idNum = Convert.ToUInt32(Console.ReadLine());
            obj.FindNameInDictById(idNum);



        }
    }
}
