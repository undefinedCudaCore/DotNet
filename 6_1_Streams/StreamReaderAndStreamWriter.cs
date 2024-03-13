using _6_1_Streams.Models;
using System.Text;

namespace _6_1_Streams
{
    internal class StreamReaderAndStreamWriter
    {
        public StreamReaderAndStreamWriter()
        {

        }

        public static void StreamWriter()
        {
            DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();

            using (var writer = new StreamWriter("CDriveDirs.txt"))
            {
                foreach (var dir in cDirs)
                {
                    writer.WriteLine(dir);
                }
            }

            string line = "";
            using (var reader = new StreamReader("CDriveDirs.txt"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        public static void ReadFileUsingStreams()
        {
            int animalColCount = 2;

            List<Animal> animals = new List<Animal>();

            string path = new DirectoryInfo(Environment.CurrentDirectory) + "\\Data\\AnimaData.txt";

            using StreamReader sr = new StreamReader(path);

            string animalLine = "";

            while ((animalLine = sr.ReadLine()) != null)
            {

                string[] animalData = animalLine.Split(',');

                if (animalData.Length != animalColCount)
                {
                    break;
                }

                Animal animal2 = new Animal()
                {
                    Id = int.Parse(animalData[0]),
                    Name = animalData[1]
                };

                animals.Add(animal2);
            }
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"Id of animal is {animal.Id} name is {animal.Name}");
            }
        }
        public static void WriteFileUsingStreams()
        {
            string path = Environment.CurrentDirectory + "\\Data";

            string content = File.ReadAllText(path + "\\AnimaData.txt");
            File.WriteAllText(Environment.CurrentDirectory + "\\Random.txt", content);
        }
        public static void WriteFileUsingStreamsWhichWillBeUsedALot()
        {
            string path = Environment.CurrentDirectory + "\\Data\\AnimaData.txt";

            using StreamWriter sw = new StreamWriter(path, true);

            Console.WriteLine("PLease insert ID:");
            string id = Console.ReadLine();
            Console.WriteLine("PLease insert Name:");
            string name = Console.ReadLine();

            sw.WriteLine($"{Environment.NewLine}{id}, {name}");
        }

        public static void ReadFromBufferFileStream()
        {
            string path = Environment.CurrentDirectory + "\\Data\\AnimaData.txt";

            using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

            byte[] buffer = new byte[fs.Length];
            int bytesRead = fs.Read(buffer, 0, buffer.Length);
            string contentFromFile = Encoding.UTF8.GetString(buffer, 0, bytesRead);

            Console.WriteLine("Content read from file: ");
            Console.WriteLine(contentFromFile);
        }

        //Exercise 2!!!
        public static void WriteFileUsingStreamsWhichWillBeUsedALotExerciseTwo(List<string> strings)
        {
            string path = Environment.CurrentDirectory + "\\Data\\Test.txt";

            using StreamWriter sw = new StreamWriter(path, true);

            foreach (string s in strings)
            {
                sw.WriteLine(s);
            }
        }

        //Exercise 3!!!
        public static void CopyFile()
        {
            string path = Environment.CurrentDirectory + "\\Data";

            File.Copy(path + "\\Test.txt", path + "\\Test211.txt", true);
        }

        //Exercise 4!!!
        public static void CountLineSimbols()
        {
            string path = Environment.CurrentDirectory + "\\Data\\Test211.txt";

            IEnumerable<string> values = File.ReadAllLines(path);

            foreach (var item in values)
            {
                Console.WriteLine(item.Length);
            }
        }

        //Exercise 5!!!
        public static void StreamWriter2()
        {
            string path = Environment.CurrentDirectory + "\\Data\\Test222.txt";

            using (var writer = new StreamWriter(path))
            {
                writer.Write(1.6650F);
                writer.Write("\n");
                writer.Write("Just testing");
                writer.Write("\n");
                writer.Write(58);
                writer.Write("\n");
                writer.Write(false);
                writer.Write("\n");
            }
        }

        //Exercise 6!!!
        public static void WriteDefaultValuesToDataFile()
        {
            string path = Environment.CurrentDirectory + "\\Data\\Data.dat";

            //Stream stream = new MemoryStream(55);

            //using (BinaryWriter bw = new BinaryWriter(stream))
            //{
            //    bw.Write(42);
            //}
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (BinaryWriter writer = new BinaryWriter(fs, Encoding.UTF8, false))
                {
                    writer.Write(1.6650F);
                    writer.Write("Just testing");
                    writer.Write(58);
                    writer.Write(false);
                }
            }
        }

        public static void DisplayDefaultValuesFromDataFile()
        {
            string path = Environment.CurrentDirectory + "\\Data\\Data.dat";
            float floatValue;
            string stringValue;
            int intValue;
            bool boolValue;

            if (File.Exists(path))
            {
                using (FileStream stream = File.Open(path, FileMode.Open))
                {
                    using (BinaryReader reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        floatValue = reader.ReadSingle();
                        stringValue = reader.ReadString();
                        intValue = reader.ReadInt32();
                        boolValue = reader.ReadBoolean();
                    }
                }

                Console.WriteLine($"Saved float to .dat file was: {floatValue}");
                Console.WriteLine($"Saved string to .dat file was: {stringValue}");
                Console.WriteLine($"Saved int to .dat file was: {intValue}");
                Console.WriteLine($"Saved bool to .dat file was: {boolValue}");
            }
        }
    }
}