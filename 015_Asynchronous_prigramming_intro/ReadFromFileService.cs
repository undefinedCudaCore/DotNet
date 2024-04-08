namespace _015_Asynchronous_prigramming_intro
{
    internal class ReadFromFileService
    {
        private List<string> _list;
        private int _count = 0;
        public async Task PrintFilesAndFolders()
        {
            DirectoryInfo[] cDirs = new DirectoryInfo(@"C:\Users\undefinedCudaCore\Desktop").GetDirectories();
            FileInfo[] cFiles = new DirectoryInfo(@"C:\Users\undefinedCudaCore\Desktop").GetFiles();

            Console.Clear();

            foreach (var folders in cDirs)
            {
                //_list.Add(folders.FullName);
                Console.WriteLine(folders);
            }
            foreach (var files in cFiles)
            {
                //_list.Add(files.FullName);
                Console.WriteLine(files);
            }
        }
        public async Task ProcessDesktopFiles(int howManyTimesDoAction)
        {
            while (_count < howManyTimesDoAction)
            {
                //_list = new List<string>();
                PrintFilesAndFolders();
                await Task.Delay(5000);
                _count++;
            }
        }
    }
}
