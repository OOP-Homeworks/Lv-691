using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anrii_HW4
{
    internal class Program
    {
        public static void Main()
        {
            const int MIN_AGE_FOR_CHENGE_NAME = 16;

            Person person = new Person();
            Console.WriteLine("How many cars do you need to create?");
            int personSizeArry = Convert.ToInt32(Console.ReadLine());
            var persons = new Person[personSizeArry];



            for (int i = 0; i < persons.Length; i++)//InPut lvaue person
            {
                persons[i] = person.Input(i);
            }


            for (int i = 0; i < persons.Length; i++)// Calc age person
            {
                Console.WriteLine($"Age int {persons[i].Name}---{ persons[i].Age()}");
            }
            


            
            for (int i = 0; i < persons.Length; i++)// Change name
            {
                
                if (persons[i].Age() < MIN_AGE_FOR_CHENGE_NAME)
                {
                    persons[i].ChangeName("Very young");
                }
            }


            for (int i = 0; i < persons.Length; i++)// Output information 
            {
                Console.WriteLine(persons[i].Output());
            }

            for (int i = 0; i < persons.Length; i++)
            {
                for (int j = i+1; j < persons.Length; j++)
                {

                    if (persons[i] == persons[j])
                    {
                        Console.WriteLine($"{persons[i]} == {persons[j]}");
                    }
                }
            }
            



        }
    }
}
