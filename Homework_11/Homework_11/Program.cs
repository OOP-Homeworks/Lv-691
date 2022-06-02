using System;

namespace Homework_11
{
    public delegate void MyDel(int f);

    class Program
    {

        static void Main(string[] args)
        {
            Student student = new Student();
            Parent parent = new Parent();
            Accountancy accountancy = new Accountancy();

            MyDel f = parent.OnMarkChange;
            MyDel s = accountancy.Stypendia;

            student.MarkChange += f;
            student.MarkChange += s;

            student.AddMark(10);
            student.AddMark(17);
            student.AddMark(23);
            student.AddMark(26);
            student.AddMark(24);
            Console.ReadKey();
        }
    }
}
