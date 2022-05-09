using System;

namespace Mala_Tsk4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Output();

            Car car1 = new Car("DBX", "white", 270000);
            car1.Output();
            var cars = new Car[4];
            for (int i = 2; i < cars.Length; i++)
            {
                cars[0] = car;
                cars[1] = car1;
                cars[i] = Car.Input(i);
            }
            Console.WriteLine("Enter the percentage by which you want to reduce the cost");
            double x = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].ChangePrice(x);
                cars[i].Output();
            }
            Console.WriteLine("Enter a color to repaint the car");
            string newColor = Console.ReadLine();
            string oldColor = "white";
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].Color.Equals(oldColor))
                {
                    cars[i].Color = newColor;
                    Console.WriteLine($"Car{i} color was changed to {newColor}");
                }
                else
                {
                    Console.WriteLine($"Car{i} color was not changed");
                }
            }
            for (int i = 0; i < cars.Length - 1; i++)
            {
                for (int j = i + 1; j < cars.Length; j++)
                {
                    if (cars[i] == cars[j])
                    {
                        Console.WriteLine($"Car{i} = Car{j}");
                    }
                    else
                    {
                        Console.WriteLine($"Car{i} and Car{j} are not equals");
                    }
                }
            }
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i].ToString());
            }
        }
    }
}
