using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryApp
{
    class Employee
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public string Id { set; get; }

        public Salary EmployeeSalary { set; get; }

        public Employee(string id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}
