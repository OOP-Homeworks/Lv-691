using System;


namespace Homeworks
{
    public class Programmer : IDeveloper, IComparable
    {

        string tool;
        string language;

        public Programmer() {}

        public Programmer(string language,string tool)
        {
            this.language = language;
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

        public string Language
        {
            get
            {
                return language;
            }

            set
            {
                language = value;
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
            Console.WriteLine($"Programmer which uses language {language} and tool {tool} has been created.");
        }

        public void Destroy()
        {
            Console.WriteLine($"Programmer has destroyed the {tool}");
        }
    }
}
