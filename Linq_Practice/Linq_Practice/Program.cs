namespace Linq_Practice
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
        }

        class Phone
        {
            public string PhoneNumber { get; set; }
            public Person Person { get; set; }
        }
        static void Main(string[] args)
        {

            Person Peter = new Person() { Name = "Peter" };
            Person Sunny = new Person() { Name = "Sunny" };
            Person Tim = new Person() { Name = "Tim" };
            Person May = new Person() { Name = "May" };

            Phone num1 = new Phone() { PhoneNumber = "01-5555555", Person = Peter };
            Phone num2 = new Phone() { PhoneNumber = "02-5555555", Person = Sunny };
            Phone num3 = new Phone() { PhoneNumber = "03-5555555", Person = Tim };
            Phone num4 = new Phone() { PhoneNumber = "04-5555555", Person = May };
            Phone num5 = new Phone() { PhoneNumber = "05-5555555", Person = Peter };

            Person[] persons = new Person[] { Peter, Sunny, Tim, May };
            Phone[] phones = new Phone[] { num1, num2, num3, num4, num5 };


            var results = 
                from phone in phones
                join person in persons on phone.Person.Name equals person.Name
                select new { Name = person.Name, PhoneNumber = phone.PhoneNumber };

            foreach (var item in results)
            {
                Console.WriteLine($"{item.Name} - {item.PhoneNumber}");
            }
        }
    }