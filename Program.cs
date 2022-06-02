using System;

namespace hw11
{
    public delegate void Del(int n);
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.Name = "Mary";
            Parent father = new Parent();
            Buh stypendia = new Buh();
            Del f = father.markCh;
            Del s = stypendia.Stypendia;

            st.MarkChange += f;
            st.MarkChange += s;
            st.AddMark(99);
            st.AddMark(90);
        }
    }
}
