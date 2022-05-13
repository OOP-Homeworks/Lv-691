using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RybalkoHomework4
{
    internal class Program
    {
        private static void Main()
        {
            var person = new Person[6];
            for (int i=0; i < 6; i++)
            {
                person[i] = Person.Input(i);
            }
            for(int i=0; i< 6; i++)
            {
                person[i].AgeX();
                person[i].OutPut();
            }
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                if (person[i].Age < 16)
                {
                    person[i].ChangeName("Very Young");
                }
                person[i].OutPut();
            }
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                for(int x = i+1 ; x < 6; x++)
                {
                    if(person[i] == person[x])
                    {
                        Console.WriteLine($"Character name {person[i].Name} person {i + 1} is equal to character name {person[x].Name} person {x + 1}");
                    }
                }
            }
            Console.ReadLine();
        }

    }
}
