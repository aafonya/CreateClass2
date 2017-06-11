using System;

namespace CreateClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person onlyPerson = new Person("OnlyPerson", 19900110);
            Room room01 = new Room();
            Room room02 = new Room();
            Employee employee = new Employee("Employee", 19900110, 1000, "profession", room01);
            Console.WriteLine("data of room01: " + room01);
            Console.WriteLine("data of room02: " + room02);
            Console.WriteLine(" ");

            Employee employee_clone = (Employee)employee.Clone();
            Console.WriteLine("Our Person: " + onlyPerson);
            Console.WriteLine("Our Employee: " + employee);
            Console.WriteLine("Our Employee Clone: " + employee_clone);
            employee_clone.Office = room02;
            Console.WriteLine("Our Employee: " + employee);
            Console.WriteLine("Our Employee Clone: " + employee_clone);
            Console.ReadKey();



            
        }
    }
}
