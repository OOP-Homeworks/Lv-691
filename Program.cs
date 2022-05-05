using System;

namespace hw4
{
   /* In the method Main() create 6 objects of Person type and enter information about them.
Then calculate and output on the console name and Age of each person; 
Change the name of persons, which Age is less then 16, to "Very Young".
Output information about all persons on the console.
Find and output information about Persons with the same names (use ==).*/

    class Program
    {
        public static void Output(Person[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                System.Console.WriteLine(arr[i].ToString());
            }
        }
        static void Main(string[] args)
        {
            Person first = new Person();
            Person second = new Person("Richard", new DateTime(2006,10,23));
            Person third = new Person(second);
            int size = 6;
            Person[] array = new Person[size];
            array[0] = first;
            array[1] = second;
            array[2] = third;

            for(int i=3; i<size; i++)
            {
                Person temp = new Person();
                Console.WriteLine($"Enter {i+1} person's name and date of birth (dd/mm/yyyy)");
                temp.Name = Console.ReadLine();
                temp.BirthYear = Convert.ToDateTime(Console.ReadLine());
                array[i] = temp;
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"{array[i].Name} is {array[i].Age()} years old ");
            }
            for (int i = 0; i < size; i++)
            {
                if (array[i].Age() < 16) array[i].Name = "Very Young";
            }
            Output(array, size);
            for (int i = 0; i < size; i++)
            {
                for (int j = i+1; j < size; j++) 
                {
                    if (array[i] == array[j])
                    {
                        Console.WriteLine($"Person {i+1} and persone {j+1} have the same name.");
                    }
                }
            }
        }
    }
}
