using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_Andrii
{
    public class Bilder : IDeveloper, IComparable
    {
        public string Tool
        { get; set; }

        public Bilder(string tool)
        {
            this.Tool = tool;
        }
        public void Create()
        {
            Console.WriteLine(Tool);
        }
        public void Destroy()
        {
            Console.WriteLine(Tool);
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
