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
        private readonly string name = "Unnamed Employee";
        private long salary;

        public long Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

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
