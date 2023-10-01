using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace select
{
    internal class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int AnnualSalary { get; set; }

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> listEmployees = new List<Employee>
            {
                new Employee
                {
                    EmployeeID = 1,
                    FirstName = "John",
                    LastName = "Fim",
                    Gender = "Male",
                    AnnualSalary = 12000,
                },
                new Employee
                {
                    EmployeeID = 2,
                    FirstName = "Mary",
                    LastName = "Lambeth",
                    Gender = "Female",
                    AnnualSalary = 48000,
                },
                new Employee
                {
                    EmployeeID = 3,
                    FirstName = "Pam",
                    LastName = "Penny",
                    Gender = "Female",
                    AnnualSalary = 84000,
                },
                new Employee
                {
                    EmployeeID = 4,
                    FirstName = "Jack",
                    LastName = "Birf",
                    Gender = "Male",
                    AnnualSalary = 53000,
                }
            };
            return listEmployees;
        }

    }
}
