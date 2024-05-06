namespace _3_1_2_FileScannerDbWriter.Services
{
    internal class FileService
    {
        public IList<Models.File> GetFileList(string fileLocationPath)
        {
            IList<string> files = Directory.GetFiles(fileLocationPath, "*", SearchOption.AllDirectories).ToList();
            IList<Models.File> fileObjects = new List<Models.File>();

            foreach (var oneFile in files)
            {
                fileObjects.Add(CreateFileObject(oneFile));
            }

            return fileObjects;
        }

        private Models.File CreateFileObject(string filePathInfo)
        {
            Guid guid = Guid.NewGuid();
            Models.File file = new Models.File();

            //foreach (var oneFilePath in filePathInfo)
            //{
            FileInfo fileInfo = new FileInfo(filePathInfo);

            file.FileId = guid;
            file.FileName = fileInfo.Name;
            file.Length = (fileInfo.Length / 1024).ToString();
            file.FullPath = filePathInfo;
            //}

            return file;
        }
    }
}
