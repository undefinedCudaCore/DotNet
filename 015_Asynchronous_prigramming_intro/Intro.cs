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
    }
}
