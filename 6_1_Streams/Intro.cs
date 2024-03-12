using _6_1_Streams.Models;

namespace _6_1_Streams
{
    internal class Intro
    {
        public Intro()
        {
            Hello = "Hello, File systems!";

            string path = Environment.CurrentDirectory;
            Console.WriteLine(Hello);
            FileAndFolderClassFunctionality(path);
        }

        public string Hello { get; set; }

        public static void FileAndFolderClassFunctionality(string path)
        {
            string rootDirPath = new DirectoryInfo(path).Parent.Parent.FullName;
            string[] directories = Directory.GetDirectories(rootDirPath, "*", SearchOption.AllDirectories);
            string[] files = Directory.GetFiles(rootDirPath, "*", SearchOption.AllDirectories);

            Console.WriteLine(rootDirPath);

            foreach (var directory in directories)
            {
                Console.WriteLine(directory);

                Console.WriteLine("------------------------------------");
            }

            foreach (var file in files)
            {
                Console.Write(Path.GetFileName(file) + " ");
                var fileInfo = new FileInfo(file);
                Console.WriteLine(Math.Round((double)fileInfo.Length / 1024) + " kilobytes");
            }

            if (Directory.Exists(path))
            {
                Console.WriteLine("Directory exists");
            }
            else
            {
                Directory.CreateDirectory(path);
            }
        }

        public static void ReadFromTxtFile()
        {
            int animalColCount = 2;
            List<Animal> animals = new List<Animal>();

            string path = @"D:\Programming\.NET\DotNet\6_1_Streams\Data\AnimaData.txt";

            string text = File.ReadAllText(path);

            string[] animaStringData = text.Split(Environment.NewLine);

            foreach (var animal in animaStringData)
            {
                string[] animalData = animal.Split(',');

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

        public static void ReadFromTxtFileLines()
        {
            int animalColCount = 2;
            List<Animal> animals = new List<Animal>();

            string path = @"D:\Programming\.NET\DotNet\6_1_Streams\Data\AnimaData.txt";

            string[] animaStringData = File.ReadAllLines(path);

            foreach (var animal in animaStringData)
            {
                string[] animalData = animal.Split(',');

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
    }
}
