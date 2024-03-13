namespace _18_Dictionary
{
    public class TaskNo01
    {
        //private static string fruitTitle = "";
        //private static bool isThereQty = false;
        //private static bool triedAddFruits = false;
        //private static int fruitQty;


        public static void NamesAndAge()
        {
            Dictionary<string, int> nameAndAge = new Dictionary<string, int>
            {
                { "Tadas", 34 },
                { "Tomas", 28},
                { "Elizabeth", 18},
                { "Emily", 36 }
            };

            foreach (var item in nameAndAge)
            {
                Console.WriteLine($"Name: {item.Key}, age: {item.Value}");
            }
        }

        public static string CountryCapital(string country)
        {
            string capital = "";

            Dictionary<string, string> dicOfCountryAndCapital = new Dictionary<string, string>
            {
                { "United Kingdom", "London" },
                { "Poland", "Warsaw"},
                { "Lithuania", "Vilnius" },
                { "Ireland", "Dublin"},
                { "Belarus", "Minsk"},
                { "Russia", "Moscow" },
                { "Wrong", "You entered wrong country." }
            };

            if (dicOfCountryAndCapital.ContainsKey(country))
            {
                capital = dicOfCountryAndCapital[country];
                return capital;
            }
            else
            {
                return dicOfCountryAndCapital["Wrong"];
            }
        }

        public static string EnterCountry()
        {
            string countryEntered = Console.ReadLine();

            if (!String.IsNullOrEmpty(countryEntered))
            {
                return countryEntered;
            }
            else
            {
                countryEntered = "Wrong";
                return countryEntered;
            }
        }

        public static Dictionary<string, int> FruitsTitleAndQty()
        {
            Dictionary<string, int> titleAndQtyOfFruits = new Dictionary<string, int>
            {
                { "Orange", 7 },
                { "Apple", 6},
                { "Banana", 8},
                { "Coconut", 6 }
            };

            return titleAndQtyOfFruits;
        }

        //public static void GetFruit()
        //{
        //    Console.WriteLine("Enter fruit title to add to list: ");
        //    fruitTitle = Console.ReadLine();
        //}

        //public static void GetFruitQty()
        //{
        //    Console.WriteLine("Enter fruit quantity to add to list: ");
        //    isThereQty = int.TryParse(Console.ReadLine(), out fruitQty);
        //}

        public static void AlredyInList()
        {
            Console.WriteLine("Fruit is alredy in list.");
        }

        public static void WrongValue()
        {
            Console.WriteLine("Entered wrong value.");
        }

        public static Dictionary<string, int> AddOrRenewFruitList(Dictionary<string, int> fruitList, string fruitTitle, string fruitQty)
        {
            bool isThereQty = int.TryParse(fruitQty, out int fruitQty2);
            if (isThereQty)
            {
                bool triedAddFruits = fruitList.TryAdd(fruitTitle, fruitQty2);

                if (!triedAddFruits)
                {
                    AlredyInList();
                    fruitList[fruitTitle] = fruitQty2;
                }
            }
            else
            {
                WrongValue();
            }
            return fruitList;
        }

        public static void PrintFruits(Dictionary<string, int> fruitList)
        {
            foreach (var item in fruitList)
            {
                Console.WriteLine($"Your fruit title is: {item.Key} and quantity {item.Value}");
            }
        }

        public static Dictionary<string, List<int>> GetStudentGrades(string studentName)
        {
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>
            {
                { "Arturas", new List<int>{ 5, 8, 9 } },
                { "Valdas", new List<int>{ 9, 10, 5 } },
                { "Tadas", new List<int>{ 6, 3, 2 } },
                { "Jogurtas", new List<int>{ 1, 1, 1 } }
            };

            return dict;
        }

        public static void PrintGrade(Dictionary<string, List<int>> studentGrade, string name)
        {
            if (studentGrade.ContainsKey(name))
            {
                foreach (var item in studentGrade[name])
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine($"Student {name} does not exist.");
            }
        }
    }
}
