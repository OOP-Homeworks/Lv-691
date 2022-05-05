namespace hw4
{
    /*
     Define class Person. Class Person should consist of:
              a) two private fields: name and birthYear (the birthday year).
		(As a type for this field you may use DataTime type.)
              b) two properties for access to these fields (can use only get)
              c) default constructor and constructor with 2 parameters 
              d) methods: - Age() - to calculate the age of person
                   	  - Input() - to enter data about person from console
                  	  - ChangeName() - to change the name of person
                 	  - ToString() 
                   	  - Output() - to output information about person (call ToString())
                 	  - operator== (equal by name)

     */
    class Person
    {
        string name;
        System.DateTime birthYear;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public System.DateTime BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }

        public Person()
        {
            name = "none";
            birthYear = new System.DateTime();
        }
        public Person(string name, System.DateTime data )
        {
            this.name = name;
            birthYear = data;

        }
        public Person(Person other)
        {
            this.name = other.name;
            this.birthYear = other.birthYear;
        }
        public int Age()
        {
            var today = System.DateTime.Today;
            int age = today.Year - this.birthYear.Year;
            return age;
        }
        public void ChangeName(string othername)
        {
            this.name = othername;
        }
        public override string ToString()
        {
            return string.Format($"Name: {name}\t\tbirthday year : {birthYear.Year}\t\tAge: {this.Age()}");
        }
        public static bool operator ==(Person a, Person b)
        {
            return (a.name == b.name);
        }
        public static bool operator !=(Person a, Person b)
        {
            return (a.name != b.name);
        }
       
    }
}

