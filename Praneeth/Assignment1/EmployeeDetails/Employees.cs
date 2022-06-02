namespace Employees
{
    public class Employee
    {
        public string? Name;
        public int? Age;
        public string? Salary;
        public string? AdressStreet1;
        public string? AdressStreet2;
        public string? City;

        public void DisplayEmployee()
        {
            Console.WriteLine($"Name : {Name}\nAge : {Age}");
        }
    }
}