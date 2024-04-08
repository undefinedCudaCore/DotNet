namespace _7_2_Generic_Exercises
{
    internal class BringItOut
    {
        public BringItOut()
        {
        }

        public static void WriteObjectsToFileWithStreamReader<T>(List<T> itemToWriteIntoFile) /*where T : ObjectForList*/
        {
            string path = Environment.CurrentDirectory + "\\Data\\Generics04.txt";

            using (var writer = new StreamWriter(path))
            {
                foreach (var obj in itemToWriteIntoFile)
                {
                    WriteOneObjectToFileWithStreamReader(obj);
                }
            }
        }

        public static void WriteOneObjectToFileWithStreamReader<T>(T itemToWriteIntoFile) /*where T : ObjectForList*/
        {
            string path = Environment.CurrentDirectory + "\\Data\\Generics02.txt";

            using (var writer = new StreamWriter(path, true))
            {
                writer.WriteLine(itemToWriteIntoFile.ToString());
                //writer.WriteLine(itemToWriteIntoFile.Age);
                //writer.WriteLine(itemToWriteIntoFile.Salary);
                //writer.WriteLine(itemToWriteIntoFile.Name);
                //writer.WriteLine(itemToWriteIntoFile.Surename);
                //writer.WriteLine(itemToWriteIntoFile.Greeting);
                //writer.WriteLine("---------------");
                writer.Flush();
            }
        }

        public static void WriteObjectsToFileWithFileDot<T>(List<T> itemToWriteIntoFile) where T : ObjectForList
        {
            foreach (var obj in itemToWriteIntoFile)
            {
                WriteOneObjectToFileWithFileDot(obj);
            }
        }


        public static void WriteOneObjectToFileWithFileDot<T>(T itemToWriteIntoFile) where T : ObjectForList
        {
            string path = Environment.CurrentDirectory + "\\Data\\Generics024.txt";

            string[] strings = {
                itemToWriteIntoFile.Age.ToString(),
                itemToWriteIntoFile.Salary.ToString(),
                itemToWriteIntoFile.Name,
                itemToWriteIntoFile.Surename,
                itemToWriteIntoFile.Greeting,
                "---------------"
            };

            File.AppendAllLines(path, strings);
        }
    }
}
