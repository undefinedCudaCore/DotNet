using _011_Linq_and_Lambda_exercises.Models;

namespace _011_Linq_and_Lambda_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1.1

            List<int> numbers = new List<int>() { 888, 45, 1, 2, 2, 3, 4, 8, 79, 22, 42 };
            List<int> numbers2 = numbers.Select(x => x * x).ToList();

            //Exercise 1.2

            List<int> negativeAndPositiveNumbers = new List<int>() { 999, 888, 45, 1, -2, 2, -3, 4, 8, -79, -22, 42, 2, 2, 3, 4, 8 };
            List<int> negativeAndPositiveNumbers2 = negativeAndPositiveNumbers.Where(x => x > 0).ToList();

            //Exercise 1.3

            List<int> negativeAndPositiveNumbersList = new List<int>() { 888, 45, 1, -2, 2, -3, 4, 8, -79, -22, 42, 2, 2, 3, 4, 8 };
            List<int> getPositiveNumbers = negativeAndPositiveNumbersList.Where(x => x < 10).ToList();

            //Exercise 1.4

            var sortNumberListAscending = negativeAndPositiveNumbers2.OrderBy(x => x).ToList();


            //Exercise 1.5

            var sortNumberListDescending = negativeAndPositiveNumbers2.OrderByDescending(x => x).ToList();

            //Exercise 1.6

            int maxValue = negativeAndPositiveNumbers2.Max(x => x);

            //Exercise 1.7

            var person = new List<Person>()
            {
                new Person { Name = "Alice", Age = 15  },
                new Person { Name = "Bob", Age = 25 },
                new Person { Name = "Dan", Age = 30 },
                new Person { Name = "Elizabeth", Age = 44 },
                new Person { Name = "Dean", Age = 66 },
                new Person { Name = "Ayan", Age = 66 },
                new Person { Name = "adrian", Age = 66 },
            };

            List<string> names = person.Select(x => x.Name).ToList();

            List<int> ages = person.Select(x => x.Age).ToList();

            var sortedByDesc = ages.OrderByDescending(x => x).ToList();
            var sortedByDescObj = person.OrderByDescending(x => x.Age).ToList();

            var nameStartWithA = names.Where(name => name.StartsWith("A"));

            var ageOverFourty = person.Where(age => age.Age > 40).OrderBy(x => x.Name);

            //Exercise 2.1.

            var personList = new List<Person>()
            {
                new Person
                {
                    Name = "Dean",
                    Age = 15,
                    Pets = new List<Pet>()
                    {
                        new Pet { PetName = "Joker"},
                        new Pet { PetName = "A Candy", PetAge = 7},
                        new Pet { PetName = "Tweety"},
                    }
                },
                new Person
                {
                    Name = "Jenna",
                    Age = 48,
                    Pets = new List<Pet>()
                    {
                        new Pet { PetName = "Daisy"},
                        new Pet { PetName = "A Mady", PetAge = 6},
                        new Pet { PetName = "Jerry"},
                    }
                },
                new Person
                {
                    Name = "Mira",
                    Age = 18,
                    Pets = new List<Pet>()
                    {
                        new Pet { PetName = "Tom"},
                        new Pet { PetName = "a Spike", PetAge = 5},
                        new Pet { PetName = "Junglee"},
                    }
                },
            };

            List<Pet> petList = personList.SelectMany(x => x.Pets).ToList();
            var petListWherePetNameStartWithA = personList.Select(x => x.Pets.Where(y => y.PetName.StartsWith("A"))).ToList();
            var petListWherePetNameStartWithA2 = personList.SelectMany(x => x.Pets.Where(y => y.PetName.ToLower().StartsWith("a"))).ToList();

            var petListOfPetNameStartWithA = personList.SelectMany(x => x.Pets.Where(y => y.PetName.ToLower().StartsWith("a"))).ToList();
            var petListOfPetAgeBiggerThanFive = petListOfPetNameStartWithA.Where(x => x.PetAge > 5);

            //Exercise 2.2.

            string sentence = "Parasites below THE Domestic he deigned thee He IVE clay flow would AND and hellas";

            List<string> returnedStringList = ReturnUpperCaseWord(sentence);

            //Exercise 3
            string FolderPath = @"C:\xampp\";
            int folderPathLength = FolderPath.Length;
            DirectoryInfo directory = new DirectoryInfo(FolderPath);

            //Get all file name + extention list
            var getAllFiles = directory.GetFiles()
                .Select(file => file.Name).ToList();

            //Get all file fullname + extention list
            var getAllFiles2 = directory.GetFileSystemInfos()
                .Select(file => file.FullName).ToList();

            //Get extention list - example: .txt, .csproj;
            var getExtentions = getAllFiles.Select(y => y.Substring(y.Length - 4, 4))
                .Where(r => r.Contains(".")).Distinct().ToList();

            //Get all files which ends .txt;
            var getFilesEndWithTxt = getAllFiles2.Where(x => x.EndsWith(".txt"));

            //Get all .txt file name list
            /* var getFileTxtNames = getAllFiles.Where(x => x.Contains(".txt")).ToString().ToList();*/ //-testing, do not check

            var getFileNames2 = getAllFiles.Where(x => x.Contains(".txt"))
                .Select(y => y.Substring(0, y.Length - 4))
                .ToList();

            var getFileNames3 = getAllFiles2.Where(x => x.Contains(".txt")).
                Select(y => y.Substring(folderPathLength, y.Length - folderPathLength))
                .ToList();

            //var getWindShellDotMany = getFileNames2.Where(r => r.Contains(".")).Select(y => y.Substring(0, y.Length - 5)).ToList();

        }

        //Exercise 2.2.

        public static List<string> ReturnUpperCaseWord(string sentence)
        {
            return sentence.Split(' ').Where(x => x == x.ToUpper()).ToList();
        }
    }
}
