using _011_linq_and_lambda_intro.Models;

namespace _011_linq_and_lambda_intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringLinqSampleOne();
            //NumberLinqSampleOne();

            var employees = new List<Emploee>
            {
                new Emploee { Name = "Alice", Department = "IT"},
                new Emploee { Name = "Evelyn", Department = "HR"},
                new Emploee { Name = "Bob", Department = "IT"},
                new Emploee { Name = "Alice", Department = "HR"},
            };

            var itEmployees = employees.Where(e => e.Department == "IT").Single(c => c.Name == "Alice");
            Console.WriteLine(itEmployees.Name);
            //foreach (var item in itEmployees)
            //{
            //    Console.WriteLine(item.Name);
            //}
        }

        private static void NumberLinqSampleOne()
        {
            int a = 1;
            int b = 2;
            int c = 3;

            //int d = (a, b, c) => a + b + c;


            List<int> numbers = new List<int>() { 888, 45, 1, 2, 2, 3, 4, 8, 79, 22, 42 };
            int firstNumber = numbers.First();
            //int firstNumberNineNonDefault = numbers.First(x => x == 9);
            int firstNumberNineDefault = numbers.FirstOrDefault(x => x == 9);
            int singleNumberEightDefault = numbers.SingleOrDefault(x => x == 8);
            bool isAnyNumberThree = numbers.Any(x => x == 3);

            IEnumerable<int> orderedNumbers = numbers.OrderBy(x => x).ToList();
            IEnumerable<int> orderedNumbers2 = numbers.OrderByDescending(x => x).ToList();

            Console.WriteLine(firstNumber);
            Console.WriteLine(firstNumberNineDefault);
            Console.WriteLine(singleNumberEightDefault);

            List<int> uniqueNumbers = numbers.Distinct().Where(n => n >= 5).ToList();

            Console.WriteLine("Min: {0}, Average: {1}, Max: {2}", numbers.Min(), numbers.Average(), numbers.Max());

            var ej = numbers.Skip(5); // Skips first 5 numbers
            var oj = numbers.Take(5); // Takes first 5 numbers

            var numberMultipliedBy10 = numbers.Select(n => n * 10);

            numberMultipliedBy10 = numberMultipliedBy10.Where(n => n >= 500);

            foreach (var item in numberMultipliedBy10)
            {
                Console.WriteLine(item);
            }
        }

        private static void StringLinqSampleOne()
        {
            List<string> cities = new List<string>()
            {
                "Vilnius",
                "Kaunas",
                "Klaipeda",
                "Alytus"
            };


            IEnumerable<string> citiesWithKIEnumerable = cities.Where(city => city.StartsWith("K"));

            string cityWithK = string.Join(", ", citiesWithKIEnumerable);
            Console.WriteLine(cityWithK);
        }
    }
}

