using System;
using System.Threading;

namespace MalaOks_HW1
{
    internal class Program
    {
        int Menu(string[] menuArr, int menuSize, int selected, bool enableCarousel)
        {
            Console.Clear();
            ConsoleKey key;
            Console.CursorVisible = false;
            bool needRedraw = true;
            do
            {
                if (needRedraw)
                {
                    for (int i = 0; i < menuSize; ++i)
                    {
                        Console.SetCursorPosition(20, 10 + i);
                        if (i == selected)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine(menuArr[i]);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }
                        else
                        {
                            Console.WriteLine(menuArr[i]);
                        }
                    }
                }
                needRedraw = true;
                ConsoleKeyInfo info = Console.ReadKey();
                key = info.Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (selected > 0)
                        {
                            selected--;
                        }
                        else if (enableCarousel)
                        {
                            selected = menuSize - 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (selected < menuSize - 1)
                        {
                            selected++;
                        }
                        else if (enableCarousel)
                        {
                            selected = 0;
                        }
                        break;
                    default:
                        needRedraw = false;
                        break;
                }
            }
            while (key != ConsoleKey.Enter);
            Console.Clear();
            return selected;
        }

        void DemoStart()
        {
            string[] menuArr = { "Сalculate the area and perimeter of a square", "Show your name and age", "Lenth, area and volume of a circle" };
            Console.CursorVisible = false;
            int choice = 0;
            while (true)
            {
                choice = Menu(menuArr, menuArr.Length, choice, true);
                switch (choice)
                {
                    case 0:
                        var sqr = new Square();
                        Console.WriteLine("Enter the length of the side of the square: ");
                        sqr.LenthSide = int.Parse(Console.ReadLine());
                        sqr.GetArea(sqr.LenthSide);
                        sqr.GetPerimeter(sqr.LenthSide);
                        sqr.Print();
                        Thread.Sleep(3000);
                        break;
                    case 1:
                        var prsn = new Person();
                        Console.WriteLine("Enter your name: ");
                        prsn.Name = Console.ReadLine();
                        Console.WriteLine("Enter your age: ");
                        prsn.Age = int.Parse(Console.ReadLine());
                        prsn.Print();
                        Thread.Sleep(3000);
                        break;
                    case 2:
                        var crcl = new Circle();
                        Console.WriteLine("Enter radius: ");
                        crcl.Radius = double.Parse(Console.ReadLine());
                        crcl.GetLenth();
                        crcl.GetArea();
                        crcl.GetVolume();
                        crcl.Print();
                        Thread.Sleep(5000);
                        break;
                }
            }
        }




        static void Main(string[] args)
        {
            var obj = new Program();
            obj.DemoStart();
        }
    }
}
