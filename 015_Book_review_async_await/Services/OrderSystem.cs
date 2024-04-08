using _015_Book_review_async_await.Models;

namespace _015_Book_review_async_await.Services
{
    internal class OrderSystem
    {
        public async Task PlaceBulkOrdersAsync(List<Book> books, int quantity, CancellationToken cancellationToken)
        {
            var orderTasks = new List<Task>();

            foreach (var book in books)
            {
                orderTasks.Add(PlaceOrderAsync(book, quantity, cancellationToken));
            }

            await Task.WhenAll(orderTasks);
            Console.WriteLine($"All orders have been processed.");
        }

        public async Task PlaceOrderAsync(Book book, int quantity, CancellationToken cancellationToken)
        {
            var random = new Random();
            var timeMs = random.Next(1000, 2500);
            Console.WriteLine($"Placing order for {quantity} copies of '{book.Title}'...");
            await Task.Delay(timeMs);
            Console.WriteLine($"Orde placed for {book.Title}.");
        }
    }
}
