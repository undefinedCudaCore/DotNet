namespace _015_Asynchronous_prigramming_intro
{
    internal static class Intro
    {
        public static async Task ProcessOrederAsync(string orderName, int delay)
        {
            Console.WriteLine($"{orderName} processing started.");
            await Task.Delay(delay);
            Console.WriteLine($"{orderName} processed.");
        }
        public static async Task<string> FetchDataAsync(string source, int delay)
        {
            Console.WriteLine($"Fetching data from {source}.");
            await Task.Delay(delay);
            return $"Data from {source}.";
        }

        public static async Task WaitForUserInputAsync()
        {
            Console.WriteLine("Press enter to continue..");
            await Task.Run(() =>
            {
                Console.ReadLine();
            });

            Console.WriteLine("Enter pressed.");
        }

        public static async Task PerformBackgroundWorkAsync()
        {
            Console.WriteLine("Background work progress 1/2.");
            await Task.Delay(1000);

            Console.WriteLine("Background work progress 2/2.");
            await Task.Delay(1000);

            Console.WriteLine("Background process started.");
            await Task.Delay(5000);

            Console.WriteLine("Background work kompleted.");

        }
    }
}
