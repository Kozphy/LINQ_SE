using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selectMany
{
    internal class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<string> Subjects { get; set; }

        public static List<Student> GetAllSuStudents()
        {
            List<Student> listStudents = new List<Student>
            {
                new Student
                {
                    Name="Tom",
                    Gender = "Male",
                    Subjects = new List<string> {"Asp.Net", "C#"}
                },
                new Student
                {
                    Name="Mike",
                    Gender = "Male",
                    Subjects = new List<string> {"Asp.Net", "C#", "AJAX"}
                },
                new Student
                {
                    Name = "Pam",
                    Gender = "Female",
                    Subjects = new List<string>{"WCF", "SQL Server", "C#"}
                },
                new Student
                {
                    Name = "Mary",
                    Gender = "Female",
                    Subjects = new List<string>{"WRF", "LINQ", "ASP.NET"}
                },
            };
            return listStudents;
        }
        public static void MethodSyntax()
        {
            // method syntax Example 1
           IEnumerable<string> subjects = GetAllSuStudents()
               .SelectMany(s => s.Subjects).Distinct();

           foreach (string subject in subjects)
           {
               Console.WriteLine(subject);
           }
        }

        public static void SQLSyntax()
        {
           // SQL syntax Example 2
           IEnumerable<string> subjects2 =
               from student in GetAllSuStudents()
               from subject in student.Subjects
               select subject;
           foreach (string subject in subjects2)
           {
               Console.WriteLine(subject);
           }
        }

        public static void SelectManyOper()
        {
            string[] stringArray =
            {
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ",
                "0123456789"
            };

            IEnumerable<char> resultMethod = stringArray.SelectMany(s => s);

            IEnumerable<char> resultSQL =
                from s in stringArray
                from c in s
                select c;

            foreach (char c in resultMethod)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("---------------");

            foreach (char c in resultSQL)
            {
                Console.WriteLine(c);
            }
        }

        public static void SelectManyOper2()
        {
            IEnumerable<string> subjects = (from student in GetAllSuStudents()
                from subject in student.Subjects
                select subject).Distinct();

            foreach (var sub in subjects)
            {
                Console.WriteLine(sub);
            }
        }

        public static void SelectManyOper3()
        {
            var result = GetAllSuStudents()
                .SelectMany(s => s.Subjects, (student, subject)
                    => new { StudentName = student.Name, Subject = subject });

            foreach (var v in result)
            {
                Console.WriteLine(v.StudentName + " - " + v.Subject);
            }
        }
    }
}
