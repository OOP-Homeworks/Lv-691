using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_Andrii
{
    internal class Programer : IDeveloper, IComparable
    {
        public Programer()
        {

        }

        public Programer(string tool)
        {
            this.Tool = tool;
        }
        string language;
        public string Tool
        {
            get { return language; }
            set { language = value; }
        }

        public void Create()
        {
            Console.WriteLine($"NEW Language {this.language}!");
        }
        public void Destroy()
        {
            Console.WriteLine($"Delete Language {this.language}!");
        }

        public int CompareTo(object? obj)
        {
            Programer a = obj as Programer;
            Bilder b = obj as Bilder;

            if (a != null)
            {
                return this.Tool.CompareTo(a.Tool);
            }
            else if (b != null)
            {
                return this.Tool.CompareTo(b.Tool);
            }
            else
            {
                throw new Exception("I`nt a developer");
            }
        }
    }
}
