
namespace _8_1_Extention_Methods_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(5.CheckIsParameterIntIsBigger(6));

            //string johnsEmail = "";
            //Console.WriteLine(johnsEmail.CreateEmail("Jonh Byte John Snow", 18, "google.com"));

            List<string> list = new List<string>()
            {
                "a",
                "b",
                "a",
                "b",
                "a",
                "b",
                "a",
                "b"
            };

            list = list.EveryOtherWord();

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            string path = Environment.CurrentDirectory + "\\extentions2.txt";
            path.WriteToFileEveryOtherWord();
        }
    }
}
