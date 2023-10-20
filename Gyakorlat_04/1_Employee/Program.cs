using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee_A = new Employee();

            Console.WriteLine(employee_A.PrintInformation());

            //Employee[] employees = new Employee[10];
            //employees[0] = employee_A;

            employee_A.salary = 1;

            Employee employee_B = new Employee("John Smith");
            employee_B.IncreaseSalary(10000);

            Console.WriteLine(employee_B.PrintInformation());

            
        }
    }
}
