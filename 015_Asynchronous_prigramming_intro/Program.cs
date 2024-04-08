namespace _015_Asynchronous_prigramming_intro
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //First example---------------------------------------------------------
            //Console.WriteLine("Order processing started");
            //await Intro.ProcessOrederAsync("Order 1", 2000);
            //await Intro.ProcessOrederAsync("Order 2", 1000);
            //Console.WriteLine("All orders processed.");

            //Second example - if we want implement all at same time-----------------
            //var fetchDataTask1 = Intro.FetchDataAsync("DataSource1", 3000);
            //var fetchDataTask2 = Intro.FetchDataAsync("DataSource2", 2550);

            //string[] results = await Task.WhenAll(fetchDataTask1, fetchDataTask2);

            //Console.WriteLine("Dashboard update:");

            //foreach (var result in results)
            //{
            //    Console.WriteLine(result);
            //}

            //Third example ---------------------------------------------------------
            //var userInputTask = Intro.WaitForUserInputAsync();
            //var backgroundWorkTask = Intro.PerformBackgroundWorkAsync();

            //await Task.WhenAny(userInputTask, backgroundWorkTask);
            //Console.WriteLine("Main task completed.");


            //Exercise No 1----------------------------------------------------------
            //ProgressBar progressBar = new ProgressBar();

            //var counterTask = progressBar.AddOneEverySecondToProgressAsynnc();
            //var printTask = progressBar.PrintThEverySecondsProgressAsynnc();

            //await Task.WhenAll(counterTask, printTask);

            //Exercise No 2----------------------------------------------------------
            //ReadFromFileService readFromFileService = new ReadFromFileService();

            //var getDesktopItems = readFromFileService.PrintFilesAndFolders();
            //var printDesktopItems = readFromFileService.ProcessDesktopFiles(10);

            //await Task.WhenAll(getDesktopItems, printDesktopItems);

        }
    }
}
