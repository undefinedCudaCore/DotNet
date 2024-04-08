namespace _015_Asynchronous_prigramming_intro
{
    internal class ReadFromFileService
    {
        private List<string> _list = new List<string>();
        private int _count = 0;
        private void GetFiles()
        {
            FileInfo[] cDirs = new DirectoryInfo(@"C:\Users\undefinedCudaCore\Desktop").GetFiles();

            Console.Clear();

            foreach (var dir in cDirs)
            {
                _list.Add(dir.FullName);
                Console.WriteLine(dir);
            }
        }
        public async Task PrintDesktopFiles(int howManyTimesDoAction)
        {
            while (_count < howManyTimesDoAction)
            {
                GetFiles();
                await Task.Delay(5000);
                _count++;
            }
        }

    }
}
