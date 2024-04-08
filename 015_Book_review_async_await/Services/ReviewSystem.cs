namespace _015_Book_review_async_await.Services
{
    internal class ReviewSystem
    {
        public async Task SubmitReviewToFirsAwailablePlatformAsync(string isbn, string review, CancellationToken cancellationToken)
        {
            var reviewTasks = new List<Task<string>>
            {
                SubmitRevieAsync(isbn, review + " - Platform A", "Platform A", cancellationToken),
                SubmitRevieAsync(isbn, review + " - Platform B", "Platform B",cancellationToken),
                SubmitRevieAsync(isbn, review + " - Platform C", "Platform C", cancellationToken),
            };

            Task<string> completedTask = await Task.WhenAny(reviewTasks);
            string result = await completedTask;
            Console.WriteLine($"Review submited to the first awailable platform {result}.");
        }

        private async Task<string> SubmitRevieAsync(string isbn, string review, string platformName, CancellationToken cancellationToken)
        {
            await Task.Delay(new Random().Next(1000, 2500), cancellationToken);

            Console.WriteLine($"Review submited: {review}");

            return platformName;
        }
    }
}
