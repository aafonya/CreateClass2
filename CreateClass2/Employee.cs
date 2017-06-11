using System;

namespace CreateClass2
{
    class Employee : Person, ICloneable
    {
        public int Salary { get; protected set; }

        public string Profession { get; protected set; }

        public Room Office { get; set; }

        public Employee(string name, int datebirth, int salary, string profession, Room office) : base(name, datebirth)
        {
            Salary = salary;
            Profession = profession;
            Office = office;
        }

        public override string ToString()
        {
            return string.Format("This instance of my object has the following:" +
                " Name = {0}, BirthDate = {1}, Salary = {2}, Profession = {3}, Office = {4} ", Name, DateBirth, Salary, Profession, Office.RoomNumber);
        }

        /*public object Clone()
        {
            return this.MemberwiseClone();
        }*/

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Office = new Room();
            return newEmployee;
        }
    }
}
