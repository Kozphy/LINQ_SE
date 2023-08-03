namespace LINQ_GroupBy
{
    public class Employee
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
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var EmployeeGroupMethod = Employee.GetAllEmployees().GroupBy(x => x.Department);

            foreach (var group in EmployeeGroupMethod)
            {
                Console.WriteLine(group.Key + "\t" + group.Count());
                Console.WriteLine("-----------------");
                foreach (var emp in group)
                {
                    Console.WriteLine(emp.Name + "\t" + emp.Department);
                }

                Console.WriteLine();
                Console.WriteLine();
            }

            var EmployeeGroupSQL = from emp in Employee.GetAllEmployees()
                                    group emp by emp.Department into eGroup
                                   select new
                                   {
                                       Key = eGroup.Key,
                                       Employees = eGroup .OrderBy(x => x.Name)
                                   };

            foreach (var group in EmployeeGroupSQL)
            {
                //Console.WriteLine(group.Key);
                Console.WriteLine(group.Key + "\t" + group.Employees.Count());
                Console.WriteLine("--------------");
                foreach (var emp in group.Employees)
                {
                    Console.WriteLine(emp.Name + "\t" + emp.Department);
                }

                Console.WriteLine(); Console.WriteLine();
                
            }

        }
    }
}