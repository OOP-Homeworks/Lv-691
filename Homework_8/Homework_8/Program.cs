using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Homework_8
{
    class Program
    {
        public static object ToLover { get; private set; }

        static void Main(string[]args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Staff("Ivan", "Ivanov", 8000));
            people.Add(new Teacher("Katya", "Ivanova", "Math", 10000));
            people.Add(new Developer("Petro", "Petrov", "JavaScript", 20000));
            people.Add(new Developer("Andrew", "Sydorov", "C# OOP", 25000));
            people.Add(new Teacher("Olena", "Frolova", ".Net", 15000));
            foreach (var p in people)
                p.Print();

            Console.WriteLine("");
            Console.WriteLine("Please, enter person's name");
            string personName = Console.ReadLine();
            bool t = false;
            foreach (var p in people)
                if (personName == p.Name)
                {
                    p.Print(); t = true;
                }
            if (!t) Console.WriteLine("There is no this person");
            Console.WriteLine("_________");
            people.Sort();
            string path = @"/ Users / chynchenkosvitlana / Desktop / File1.pages";
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine("Sorted names!");
                foreach (Person x in people)
                    sw.WriteLine(x.Name);
            }
            Console.WriteLine("______");
            List<Staff> Employees = new List<Staff>();
            foreach (Staff p in people)
            {
                if (p.GetType() == typeof(Developer))
                    Employees.Add(p);
                if (p.GetType() == typeof(Teacher))
                    Employees.Add(p);
            }
            foreach (Staff p in Employees)
            {
                p.Print();
            }
            Employees.Sort();
            Console.WriteLine("_____ after sorting employees by salary\n");
            foreach (Staff s in Employees)
                s.Print();
            Console.ReadLine();

            //2
            List<Shape> shapes = new List<Shape>();
            for(var i = 0; i<11; i++)
            {
                Console.WriteLine("Enter circle or square");
                string word = Console.ReadLine();
                if (word == "circle")
                {
                    Console.WriteLine("Write its name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Write its radius");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    shapes.Add(new Circle(name, radius));
                    i++;
                }
                else if (word == "square")
                {
                    Console.WriteLine("Write its name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Write its side");
                    double side = Convert.ToDouble(Console.ReadLine());
                    shapes.Add(new Square(name, side));
                    i++;
                }
                else
                {
                    Console.WriteLine("Your word is not correct.Write circle or square");
                    i--;
                }
                double maxPerimeter = shapes.Max(p => p.Perimeter());
                foreach (var shape in shapes.FindAll(p=>p.Perimeter()==maxPerimeter))
                {
                    Console.WriteLine(value: $"Shape with the largest perimeter is {shape.Name}. Perimeter is {shape.Perimeter()}");
                }
                shapes.Sort();
                foreach(var shape in shapes)
                {
                    Console.WriteLine($"Name of shape {shape.Name}.Area is {shape.Area()}");
                }
                Console.ReadKey();
            }

        }
    }


}
