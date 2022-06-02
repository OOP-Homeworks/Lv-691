using System;
namespace Homework_11
{
    public class Parent: Student
    {
        public void OnMarkChange(int someMark)
        {
            Console.WriteLine($"{Name} new mark is"+someMark);
        }
    }
}
