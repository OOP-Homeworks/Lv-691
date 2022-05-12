using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_4
{
    class Car
    {
        public const string MARK = "BMW";
        private string name;
        private string color;

        public string Color
            {
                set { color = value; }
                get { return color; }
            }
    private double price;

    public Car()
        {
            name = "X5";
            color = "black";
            price = 100000;

        }
    public Car (string name, string color, double price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
        }
    public static Car Input(int i)
        {
            Console.Write($"Enter {i + 1} car name");
            string name = Console.ReadLine();
            Console.Write($"Enter {i + 1} car color");
            string color = Console.ReadLine();
            Console.Write($"Enter {i + 1} car price");
            double price = Convert.ToInt32(Console.ReadLine());
            Car car = new Car(name, color, price);
            return car;
        }
        public void Output()
        {
            Console.WriteLine("Car mark" + MARK + "Car name" + name + "with color" + color + "& price" + price);
        }
        public void ChangePrice(double x)
        {
            price -= price * x / 100;
        }

        public static bool operator == (Car first, Car second)
        {
            return (first.name == second.name) && (first.price == second.price);

        }

        public static bool operator != (Car first, Car second)
        {
            return (first.name == second.name) && (first.price == second.price);
        }

        public override string ToString()
        {
            return "Car mark" + MARK + "car name" + name + "with color" + color + "& price" + price;
        }
    }
}
