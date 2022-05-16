using System;
using System.Collections.Generic;
using System.Text;

namespace hw5_osypov
{
    class Builder : IDeveloper, IComparable<IDeveloper>
    {
        string tool;

        public string Tool 
        { 
            get { return tool; }
            set { tool = value; } 
        }
    
        public Builder(string tool)
        {
            this.tool = tool;
        }
        public void Create()
        {
            Console.WriteLine("Builder with {0} can create something", tool);
        }
        public void Destroy()
        {
            Console.WriteLine("Builder with {0} can destroy anything", tool);
        }
        int IComparable<IDeveloper>.CompareTo(IDeveloper other)
        {
            return string.Compare(this.tool, other.Tool);
        }
    }
}
