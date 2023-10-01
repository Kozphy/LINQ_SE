using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_groupBy
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }

        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>()
            {
                new Employee { ID = 1, Name = "Mark", Gender = "Male", Department = "IT", Salary = 45000 },
                new Employee { ID = 2, Name = "Steve", Gender = "Male", Department = "HR", Salary = 55000 },
                new Employee { ID = 3, Name = "Ben", Gender = "Male", Department = "IT", Salary = 65000 },
                new Employee { ID = 4, Name = "Philip", Gender = "Male", Department = "IT", Salary = 55000 },
                new Employee { ID = 5, Name = "Mary", Gender = "Female", Department = "HR", Salary = 48000 },
            };
        }
        public static void GroupMethod()
        {
            var EmployeeGroupMethod =
                Employee.GetAllEmployees()
                    .GroupBy(emp => emp.Department);

            foreach (var group in EmployeeGroupMethod)
            {
                Console.WriteLine(group.Key + "\t" + group.Count());
                Console.WriteLine("-----------------");
                foreach (var emp in group)
                {
                    Console.WriteLine(emp.Name + "\t" + emp.Gender + "\t" + emp.Department);

                }


                double averageSalary = group.Average(emp => emp.Salary);
                Console.WriteLine($"Average Salary: {averageSalary:F2}");

                Console.WriteLine();
            }
        }

        public static void GroupSQL()
        {
            var EmployeeGroupSQL =
                                    from emp in Employee.GetAllEmployees()
                                    group emp by emp.Department into eGroup
                                    select new
                                    {
                                        Key = eGroup.Key,
                                        Employees = eGroup.OrderBy(x => x.Name),
                                        Salary = eGroup.Average(x => x.Salary)
                                    };

            foreach (var group in EmployeeGroupSQL)
            {
                //Console.WriteLine(group.Key);
                Console.WriteLine(group.Key + "\t" + group.Employees.Count());
                Console.WriteLine("--------------");
                foreach (var emp in group.Employees)
                {
                    Console.WriteLine(emp.Name + "\t" + emp.Gender + "\t" + emp.Department);
                }

                Console.WriteLine($"Average Salary: {group.Salary:F2}");

                Console.WriteLine();
                Console.WriteLine();
            }
        }

    }
}
