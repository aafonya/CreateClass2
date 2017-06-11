using System;


namespace CreateClass2
{
    class Person
    {
        public string Name { get; protected set; }

        public int DateBirth { get; protected set; }

        public Person(string name, int dateBirth)
        {
            this.Name = name;
            this.DateBirth = dateBirth;
        }



        enum Gender { Female, Male }

        public override string ToString()
        {
            return string.Format("This instance of my object has the following: Name = {0}, BirthDate = {1}", Name, DateBirth);
        }
    }
}
