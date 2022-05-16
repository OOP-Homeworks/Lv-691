using System;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Output();

            Car car2 = new Car("x3", "white", 2224.56);
            car2.Output();
            var cars = new Car[4];

            for (int i = 2; i<cars.Length; i++)
            {
                cars[0] = car;
                cars[1] = car2;
                cars[i] = Car.Input(i);
            }
            Console.WriteLine("enter percents you would like to reduce prices of cars");
            float percent = Convert.ToSingle(Console.ReadLine());
            for (int i = 0; i<cars.Length; i++)
            {
                cars[i].ChangePrice(percent);
                cars[i].Output();
            }
            Console.Write("Enter new color");
            string newColor = Console.ReadLine();
            string oldColor = "white";
            for (int i = 0; i<cars.Length; i++)
            {
                if (cars[i].Color.Equals(oldColor))
                {
                    cars[i].Color = newColor;
                    Console.WriteLine($"Car {i + 1} has new color - " + newColor);
                }
                else
                {
                    Console.WriteLine($"Color {i + 1} was not changed");
                }
            }
            for(int i = 0; i<cars.Length; i++)
            {
                for (int j = i+1; j<cars.Length; j++)
                {
                    if (cars[i] == cars[j])
                    {
                        Console.WriteLine($"{cars[i]} and {cars[j]} are equals");
                    }
                    else
                    {
                        Console.WriteLine("Cars are not equals");
                    }
                    Console.ReadKey();
                }
            }


            Person person = new Person();
            person.Output();

            Person person2 = new Person("Tom", 1974);
            person2.Output();

            var persons = new Person[6];

            for (int i = 2; i < persons.Length; i++)
            {
                persons[0] = person;
                persons[1] = person2;
                persons[i] = Person.Input(i);
            }

            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].CountAge();
                persons[i].Output();
            }

            string newName = "Very young";
            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i].CountAge.Equals(0 - 15))
                {
                    persons[i].Name = newName;
                    Console.WriteLine($"Person {i + 1} has new name - " + newName);
                }
                else
                {
                    Console.WriteLine($"Name {i + 1} was not changed");
                }
            }

            Console.WriteLine(persons[i].ToString());

            for (int i = 0; i < persons.Length; i++)
            {
                for (int j = i + 1; j < persons.Length; j++)
                {
                    if (persons[i] == persons[j])
                    {
                        Console.WriteLine($"{persons[i]} and {persons[j]} are equals");
                    }
                    else
                    {
                        Console.WriteLine("Persons are not equals");
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}
