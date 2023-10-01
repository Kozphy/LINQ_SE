namespace Linq_groupBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("method syntax");
            Employee.GroupMethod();
            Console.WriteLine();
            Console.WriteLine("SQL syntax");
            Employee.GroupSQL();

        }
    }
}