using System;
using System.Collections.Generic;

namespace Mala_tsk5
{
    internal class DemoIfy
    {
        List<IFlyable> flyable = new();
        public DemoIfy()
        {
            flyable.Add(new Bird("Owl", true));
            flyable.Add(new Bird("Penguin", false));
            flyable.Add(new Plane("Gulfstream G450", 13700));
            flyable.Add(new Plane("Challenger 604", 12500));
        }
        public void CallFlyMethod()
        {
            foreach (IFlyable item in flyable)
            {
                item.Fly();
            }
        }
    }

    internal class Program
    {
        List<int> myCall = new();
        private void CreateListMyCall()
        {
            int num;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number");
                num = Convert.ToInt32(Console.ReadLine());
                myCall.Add(num);
            }
        }

        private void PrintCollection()
        {
            foreach (var item in myCall)
            {
                Console.WriteLine(item);
            }
        }

        private void FindIndex10()
        {
            for (int i = 0; i < myCall.Count; i++)
            {
                if (myCall[i].Equals(-10))
                {
                    Console.WriteLine($"The index number of an element equal to -10 in the collection; index = {i}");
                }
            }
        }

        private void RemoveEachElementBigger20()
        {
            //в данном случае не нужен try cath, т.к. перебор коллекции, т.е даже если использовать
            //RemoveAt, он выкидывает исключение, но тут есть if )) если не будет такого элемента то до удаления и дело не дойдет
            // а если элемент есть то и индекс у него есть и любой метод безопасен и Remove и RemoveAt
            for (int i = 0; i < myCall.Count; i++)
            {
                if (myCall[i] > 20)
                {
                    myCall.Remove(myCall[i]);
                    --i;
                }
            }
        }
        private void InsertWithoutTry()
        {
            for (int i = 0; i < myCall.Count; i++)
            {
                //в случае перебора коллекции и поиска нужного индекса try cath не нужен,
                //т.к. в блоке if если нет такой позиции то условие вернет false
                //и соответственно логика внутри условия не выполнится,
                // в данном случае он недостижим. myCall.Count например если будет всего 4 элемента то в принципе
                // i максимум будет = 3, после Insert будет 4 элемента,
                // но все равно остальные условия в принципе просто никогда не выполнятся,
                // хотя будут проверятся на каждой итерации))

                if (i == 2)
                {
                    myCall.Insert(i, 1);
                }
                if (i == 5)
                {
                    myCall.Insert(i, -4);
                }
                if (i == 8)
                {
                    myCall.Insert(i, -3);
                }
                Console.WriteLine(myCall[i]);
            }
        }


        private void InsertWithtTryCath()
        {
            //а вот вариант в котором нужен try cath, если например коллекция большая, то выгоднее не перебирать ее
            //а сразу добавить по индексу нужный элемент
            try
            {
                myCall.Insert(2, 1);
                myCall.Insert(5, -4);
                myCall.Insert(8, -3);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The collection has a length less than the required element index number");
            }
        }

        private void SotMyCall()
        {
            myCall.Sort();
        }


        static void Main(string[] args)
        {
            DemoIfy iflyObj = new();
            iflyObj.CallFlyMethod();

            Program obj = new();
            obj.CreateListMyCall();

            Console.WriteLine("Sourse collection:");
            obj.PrintCollection();

            obj.FindIndex10();
            Console.WriteLine("Collection without elements > 20");
            obj.RemoveEachElementBigger20();
            obj.PrintCollection();

            Console.WriteLine("Insert elements 1, -4, -3 in positions 2, 5, 8. Print new collection.VERSION 1: without try cath");
            obj.InsertWithoutTry();           
            obj.PrintCollection();
            
            Console.WriteLine("Insert elements 1, -4, -3 in positions 2, 5, 8. Print new collection.VERSION 2: with try catch");
            obj.InsertWithtTryCath();
            Console.WriteLine("Collection after insert:");
            obj.PrintCollection();

            obj.SotMyCall();
            Console.WriteLine("Sorted collection");
            obj.PrintCollection();            
        }
    }
}
