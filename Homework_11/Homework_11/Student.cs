using System;
using System.Collections.Generic;
using static Homework_11.Program;

namespace Homework_11
{
    public class Student
    {
        private string name;

        public string Name { get { return this.name = "Andriy"; } }
        public List<int> marks = new List<int>();
        public event MyDel MarkChange;

        public void AddMark(int newMark)
        {
            marks.Add(10);
            if (MarkChange != null)
                MarkChange.Invoke(newMark);
        }
    }
}
