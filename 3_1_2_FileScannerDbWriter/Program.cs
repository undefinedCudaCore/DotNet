using _3_1_2_FileScannerDbWriter.Services;

namespace _3_1_004_FileScannerDbWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileService fileService = new FileService();
            fileService.GetFileList("C:\\Python312");
        }
    }
}
