/**
Define string name and integer age. 
Output question "What is your name?"; 
Read value name and output next question: "How old are you, (name)?". 
Read value age and output whole information
*/
using System;

namespace Exercises_1
{
    class UserInformation
    {
        static void Main(String[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"How old are you, {userName} ?");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"USER INFORMATION\nNAME:\t{userName}.\nAge:\t{userAge}.");
        }
    }
}