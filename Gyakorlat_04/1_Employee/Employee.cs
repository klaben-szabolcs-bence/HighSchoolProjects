using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Employee
{
    class Employee
    {
        int invisibleInteger;
        internal readonly string name = "Unnamed Employee";
        internal long salary;

        public Employee()
        {
        }

        public Employee(string name) {
            this.name = name;
        }

        public Employee(string name, long salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public void IncreaseSalary(long increment)
        {
            salary += increment;
        }

        public string PrintInformation()
        {
            return $"Name: {name}, Salary: {salary}";
        }
    }
}
