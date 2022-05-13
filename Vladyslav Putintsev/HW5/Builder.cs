using System;


namespace Homeworks
{
    public class Builder :IDeveloper, IComparable
    {
        string tool;

        public Builder() { }

        public Builder(string tool)
        {
            this.tool = tool;
        }

        public string Tool
        {
            get
            {
                return tool;
            }

            set
            {
                tool = value;
            }
        }

        public int CompareTo(object obj)
        {

            if (obj == null) return 1;

            IDeveloper o=obj as IDeveloper;
            return Tool.CompareTo(o.Tool);
        }

        public void Create()
        {
            Console.WriteLine($"Builder has created {tool}");
        }

        public void Destroy()
        {
            Console.WriteLine($"Builder has destroyed {tool}");
        }
    }
}
