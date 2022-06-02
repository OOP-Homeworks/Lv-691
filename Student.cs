using System;
using System.Collections.Generic;
using System.Text;

namespace hw11
{
    class Student
    {
        private string name;
        public string Name
        { get; set; }
        public List<int> marks = new List<int>();
        public event Del MarkChange;
        public void AddMark(int nm)
        {
            marks.Add(nm);
            if (MarkChange != null) MarkChange.Invoke(nm);
        }
    }
}
