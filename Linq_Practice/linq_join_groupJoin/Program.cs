using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace linq_join_groupJoin
{
    internal class Program
    {

        static List<Book> books = new List<Book>
            {
                new Book("ASP", 1,620),
                new Book("128", 2, 160),
                new Book("256", 2, 88),
                new Book("Note", 3, 238),
                new Book("Journey", 3, 228),
            };

        static List<Category> categories = new List<Category>
            {
                new Category{Id=1, CategoryName="Program"},
                new Category{Id=2, CategoryName="Diet"}
            };

        static void Main(string[] args)
        {
            //LeftJoin();
            GroupJoin();
        }

        public static void GroupJoin()
        {
            Func<Book, int> keySelectorOfBook = book => book.CategoryId;
            Func<Category, int> keySelectorOfCategory = category => category.Id;

            var query = books.GroupJoin(
                categories,
                keySelectorOfBook,
                keySelectorOfCategory,
                (b, subCategory) => new {Book = b, Categories = subCategory.DefaultIfEmpty()}
            ).Select(x => new BookResult{Name = x.Book.Name, CategoryName = x.Categories?.First()?.CategoryName ?? string.Empty})
            .ToList();

            query.Dump();
        }

        public static void LeftJoin()
        {

            var query = (from book in books
                         join category in categories on book.CategoryId equals category.Id into bc
                         from subCategory in bc.DefaultIfEmpty()
                         select new BookResult
                         {
                             Name = book.Name,
                             CategoryName = subCategory?.CategoryName ?? string.Empty
                         }).ToList();

            query.Dump();
        }
    }



    class BookResult
    {
        public string Name { get; set; }

        public string CategoryName { get; set; }

        public override string ToString()
        {
            return $"{Name,-20}\t, {CategoryName}";
        }
    }

    class Book
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int UnitPrice { get; set; }

        public Book(string name, int categoryId, int unitPrice)
        {
            this.Name = name;
            this.CategoryId = categoryId;
            this.UnitPrice = unitPrice;
        }
    }

    class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }

    static class IEnumerableExts
    {
        public static void Dump<T>(this IEnumerable<T> source)
        {
            foreach (var item in source)
            {
                Console.WriteLine(item);
            }
        }
    }
}