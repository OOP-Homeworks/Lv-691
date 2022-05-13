using System;


namespace Homeworks
{
    internal class Program
    {
        /// <summary>
        /// Створіть клас Cat.  
        /// У кішки буде властивість «рівень ситості» і метод «з'їсти щось».  
        /// Створіть enum Їжа (риба, миша ...).  
        /// Кожен вид їжі повинен по-різному змінювати рівень ситості.
        /// </summary>

        enum CatFood
        {
            Mouse=1,
            Sausage = 2,
            Chicken = 3,
            Fish = 4,
            Meat =5
        }

        class Cat
        {
            string name;
            string mark;
            int satlevel;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public string Mark
            {
                get { return mark; }
                set { mark = value; }
            }

            public int Satlevel { get { return satlevel; } }

            public void Eating(CatFood catfood)
            {
                satlevel += (int)catfood;
            }

        }

        static void Main(string[] args)
        {
          
            Cat cat=new Cat();
            cat.Name = "Jakie";
            cat.Mark = "Pug";
            cat.Eating(CatFood.Mouse);
            Console.WriteLine("Satiety level is {0}",cat.Satlevel);
            cat.Eating(CatFood.Fish);
            Console.WriteLine("Satiety level is {0}", cat.Satlevel);

            Console.ReadKey();
        }
            
            
    }
}
