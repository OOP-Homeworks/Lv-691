using System;

namespace Mala_HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Output();
            //took 3 for easier debug
            var persons = new Person[3];
            for (int i = 1; i < persons.Length; i++)
            {
                persons[0] = person;
                persons[i] = Person.Input();
            }
            foreach (var item in persons)
            {
                item.Output();
            }

            foreach (var item in persons)
            {
                if (item.GetAge(item.BirthYear) < 16)
                {
                    item.ChangeName("Very young");
                }
            }
            Console.WriteLine("List persons with changed names");
            foreach (var item in persons)
            {
                item.Output();
            }
            for (int i = 0; i < persons.Length - 1; i++)
            {
                for (int j = i + 1; j < persons.Length; j++)
                {
                    if (persons[i] == persons[j])
                    {
                        Console.WriteLine($"Person{i}({persons[i].Name}) = Person{j}({persons[j].Name})");
                    }
                    else
                    {
                        Console.WriteLine($"Person{i}({persons[i].Name}) and Person{j}({persons[j].Name}) are not equals");
                    }
                }
            }



        }
    }
}
