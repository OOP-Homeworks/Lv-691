namespace HW5_Andrii
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            
            List<IDeveloper> developers = new List<IDeveloper>();

            developers.Add(new Programer("Greck"));
            developers.Add(new Programer("Celena"));
            developers.Add(new Bilder("Bohdan"));
            developers.Add(new Bilder("Andrii"));

            

            foreach (IDeveloper a in developers)
            {
                a.Create();
                a.Destroy();
            }
            developers.Sort();
            foreach (IDeveloper a in developers)
            {
                Console.WriteLine(a.Tool);
            }

            
            

        }
    }
}