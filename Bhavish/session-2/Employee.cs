using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
     class _Employee
    {
        public string _name { get; set; }   
        public int _age { get; set; }
        public double _salary { get; set; }
        public string _address1 { get; set; }
        public string _address2 { get; set; }
        public _Employee(string name, int age, double salary, string address1, string address2)
        {
            _name = name;
            _age = age;
            _salary = salary;
            _address1 = address1;
            _address2 = address2;  
        }
        public void display()
        {
            Console.WriteLine(_name + " of age " +_age);
        }

    }
}
