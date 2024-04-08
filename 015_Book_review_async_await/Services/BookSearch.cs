using _015_Book_review_async_await.Models;

namespace _015_Book_review_async_await.Services
{
    internal class BookSearch
    {
        private List<Book> books = new List<Book>
        {
            new Book { Title = "C#0", Author = "First", ISBN = "546564"},
            new Book { Title = "C#1", Author = "Second", ISBN = "456546"},
            new Book { Title = "C#2", Author = "Third", ISBN = "45689456"}
        };

        public async Task<Book> SearcBookAsync(string title)
        {
            var random = new Random();
            var timeMs = random.Next(1000, 2000);
            await Task.Delay(timeMs);

            //should contain ifs
            Console.WriteLine($"Book '{title}' found.");

            //can be async
            return books.Find(b => b.Title.Contains(title));
        }
    }
}
