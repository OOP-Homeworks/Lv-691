class Person
        {
            string name;
            DateTime birthYear;

            public string Name { get => name; } 
            public DateTime BirthYear { get => birthYear; }

            public Person() { }

            public Person(string _name,int _birthYear)
            {
                name = _name;
                birthYear = new DateTime().AddYears(_birthYear - 1);
            }

            public int Age()
            {
                int age = DateTime.Now.Year - birthYear.Year;
                if (birthYear > DateTime.Now.AddYears(-age))
                {
                    age--;
                }
                return age;  
            }

            public void Input()
            {
                Console.WriteLine("Please enter Name");
                name=Console.ReadLine();
                Console.WriteLine("Please enter Birth Year");
                int year = Convert.ToInt16(Console.ReadLine());
                birthYear = new DateTime().AddYears(year-1);
            }

            public void ChangeName(string _name)
            {
                name=_name;
            }

            public override string ToString()
            {
                return String.Format("Name: {0}; Age:{1} years",name,this.Age());
            }

            public void Output()
            {
                Console.WriteLine( this.ToString());
            }

            public static bool operator == (Person first, Person second)
            {
                return first.Name == second.Name;
            }

            public static bool operator !=(Person first, Person second)
            {
                return !(first == second);
            }

            public override bool Equals (object _person)
            {
                if (_person == null)
                {
                    return false;
                }
                else
                {
                    Person person= _person as Person;
                    return this.Name == person.Name;
                }
            }

            public override int GetHashCode()
            {
                return this.GetHashCode();
            }
        }


        static void Main(string[] args)
        {

            Person[] persons = new Person[6];
            for(int i=0;i<6;i++)
            {
                Person person = new Person();
                person.Input();
                person.Output();
                if (person.Age() < 16)
                {
                    person.ChangeName("Very Young");
                }
                persons[i] = person;
            }

            //output information about all persons. We can output it immediatelly in loop above, but the extra step was requested in the task.
            foreach(Person p in persons )
            {
                p.Output();
            }

            for(int i=0;i<5;i++)
            {
                for(int j=i+1;j<6;j++)
                {
                    if(persons[i]==persons[j])
                    {
                        persons[i].Output();
                        persons[j].Output();
                    }
                }
            }
            Console.ReadKey();

            
        }
