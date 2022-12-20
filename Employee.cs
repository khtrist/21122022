using System;
using System.Collections.Generic;
using System.Text;

namespace _21122022
{
    internal class Employee:Human
    {
        public int Salary;
        public string Position;

        public Employee(string name, string surname, int age ,int salary ,string position) : base(name, surname, age)
        {
            
        }
    }
}
