using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mala_Tsk4
{
    internal class Car
    {
        private string name;
        private string color;
        private double price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        private const string COMPANY_NAME = "Aston Martin";
        public Car()
        {
            name = "Rapid";
            color = "Diablo red";
            price = 250000;
        }
        public Car(string model, string crl, double prc)
        {
            name = model;
            color = crl;
            price = prc;
        }

        public static Car Input(int i)
        {
            Console.WriteLine($"Please enter {i + 1} car model");
            string mdl = Console.ReadLine();
            Console.WriteLine($"Please enter color");
            string clr = Console.ReadLine();
            Console.WriteLine($"Please enter price");
            double prc = Convert.ToDouble(Console.ReadLine());
            return new Car(mdl, clr, prc);
        }
        public void Output()
        {
            Console.WriteLine($"Yor car: \n Mark = {COMPANY_NAME}; \n Model = {Name};" +
                $" \n Color = {Color}; \n Price = {Price}");

        }
        public void ChangePrice(double x)
        {
            Price -= Price * x / 100;
        }
        public static bool operator ==(Car car1, Car car2)
        {
            return (car1.Name == car2.Name && car1.Price == car2.Price);
        }
        public static bool operator !=(Car car1, Car car2)
        {
            return !(car1.Name == car2.Name && car1.Price == car2.Price);
        }
        public override string ToString()
        {
            return $"Yor car: \n Mark = {COMPANY_NAME}; \n Model = {Name};" +
                $" \n Color = {Color}; \n Price = {Price}";
        }
    }
}
