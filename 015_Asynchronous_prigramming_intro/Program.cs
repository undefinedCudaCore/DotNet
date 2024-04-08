namespace _015_Asynchronous_prigramming_intro
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //First example
            Console.WriteLine("Order processing started");
            await Intro.ProcessOrederAsync("Order 1", 2000);
            await Intro.ProcessOrederAsync("Order 2", 1000);
            Console.WriteLine("All orders processed.");
        }
    }
}
