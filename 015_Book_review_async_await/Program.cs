using _015_Book_review_async_await.Models;
using _015_Book_review_async_await.Services;

namespace _015_Book_review_async_await
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var bookSearch = new BookSearch();
            var orderSystem = new OrderSystem();
            var reviewSystem = new ReviewSystem();
            CancellationTokenSource cts = new CancellationTokenSource();

            try
            {
                // Search for book
                var book1 = await bookSearch.SearcBookAsync("C#1");
                var book2 = await bookSearch.SearcBookAsync("C#2");
                var booksToOrder = new List<Book> { book1, book2 };

                //Place bulk orders with cancelation token
                var bulkOrderTask = orderSystem.PlaceBulkOrdersAsync(booksToOrder, 1, cts.Token);

                // Simulate user cancelation after x seconds (for demonstration)
                var cancelTask = Task.Run(() =>
                {
                    Task.Delay(3000).Wait();
                    cts.Cancel();
                });

                await bulkOrderTask;

                //Submit as review to the first available platform
                if (book1 != null)
                {
                    await reviewSystem.SubmitReviewToFirsAwailablePlatformAsync(book1.ISBN, "An insinghtful read!", cts.Token);
                }
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Operation was canceled.");
            }

        }
    }
}
