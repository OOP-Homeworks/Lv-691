using System;
using System.Collections.Generic;
using System.Text;

namespace hw5
{
    class Builder:IDeveloper, IComparable<IDeveloper>
    {
        string tool;
        public Builder()
        {
            tool = "unknown";
        }
        public Builder(string t)
        {
            tool = t;
        }
        public string Tool
        {
            get { return tool; }
            set { tool = value; }
        }
        void IDeveloper.Create()
        {
            Console.WriteLine($"Builder have buidt something with {tool}");
        }
        void IDeveloper.Destroy()
        {
            Console.WriteLine("Builder have destroyed house");
        }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return String.Compare(this.Tool, other.Tool);
        }
    }
}
