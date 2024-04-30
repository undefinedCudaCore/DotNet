using _1_EF_Intro.Models;
using Microsoft.EntityFrameworkCore;

namespace _1_EF_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BookContent())
            {
                // Atlieka auto update-database
                db.Database.EnsureCreated();

                while (true)
                {
                    Console.WriteLine("Please select action:");
                    Console.WriteLine("1. Create book.");
                    Console.WriteLine("2. Update book.");
                    Console.WriteLine("3. Delete book.");
                    Console.WriteLine("4. Create page in book.");
                    Console.WriteLine("5. Read books and pages.");

                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            CreateBook(db);
                            break;
                        case 2:
                            UpdateBook(db);
                            break;
                        case 3:
                            RemoveBook(db); //exercise
                            break;
                        case 4:
                            CreatePageInBook(db);
                            break;
                        case 5:
                            ReadBooksAndPages(db);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private static void ReadBooksAndPages(BookContent db)
        {
            var books = db.Books.Include(b => b.Pages).ToList();

            if (!books.Any())
            {
                Console.WriteLine("No books were found");
                return;
            }

            foreach (var book in books)
            {
                Console.WriteLine($"Book: {book.Name} (ID: {book.BookId})");

                foreach (var page in book.Pages)
                {
                    Console.WriteLine($"\tPage {page.Number}: {page.Content} - {page.PublishTime}");
                }
            }
        }

        private static void CreatePageInBook(BookContent db)
        {
            Console.WriteLine("Enter book ID:");
            int bookId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter page NO:");
            int pageNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter book content:");
            string content = Console.ReadLine();

            var page = new Page(pageNo, content) { BookId = bookId };
            db.Pages.Add(page);
            db.SaveChanges();

            Console.WriteLine($"Page updated succ. with ID {page.BookId}");
        }

        private static void RemoveBook(BookContent db)
        {
            Console.WriteLine("Enter book ID:");
            int bookId = Convert.ToInt32(Console.ReadLine());

            var book = db.Books.Find(bookId);
            db.Books.Remove(book);
            db.SaveChanges();
        }

        private static void UpdateBook(BookContent db)
        {
            Console.WriteLine("Enter book ID:");
            int bookId = Convert.ToInt32(Console.ReadLine());

            var book = db.Books.Find(bookId);

            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            Console.WriteLine("Enter book name:");

            book.Name = Console.ReadLine();
            db.SaveChanges(); // Paleidzia Query pacioje DB

            Console.WriteLine($"Book updated succ. with ID {book.BookId}");
        }

        private static void CreateBook(BookContent db)
        {
            Console.WriteLine("Enter book name:");
            string name = Console.ReadLine();

            var book = new Book(name, new List<Page>());
            db.Books.Add(book); // Tik fiziskai ideda DbContext i nauja objekta
            db.SaveChanges(); // Paleidzia Query pacioje DB

            Console.WriteLine($"Book created succ. with ID {book.BookId}");
        }
    }
}
