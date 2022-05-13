using System;


namespace hw4_osypov
{
    class Program
    {

        static void Main(string[] args)
        {
            var persons = new Person[6];

            for(int i = 0; i < persons.Length; i++)
            {
                persons[i] = Person.Input(i);
            }
            Console.WriteLine("Outputs information ");
            foreach (Person person in persons)
            {
                person.Outputs();
                person.ChangeName();
            }
            Console.WriteLine("Outputs information with changed names");
            foreach (Person person in persons)
            {
                person.Outputs();
            }

            for (int i = 0; i < persons.Length; i++)
            {
                for (int j = i + 1; j < persons.Length; j++)
                {
                    if (persons[i].Name == persons[j].Name)
                    {
                        Console.WriteLine("Outpus information of persons with same names");
                        persons[i].Outputs();
                        persons[j].Outputs();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
