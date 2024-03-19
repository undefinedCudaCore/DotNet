namespace _7_3_1_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var newCityListNull = new Dictionary<int, string>(0, null);

            var newCityList = new Dictionary<int, string>(){
                {0, "London"},
                //{1, "London"},
                {2, "New York"},
                {3, "Mumbai"}
            };
            City<int, string> city = new City<int, string>(newCityList);

            /////Print list
            //city.PrintList();

            /////Convewrt to array
            //Console.WriteLine(city.ChangeListToArray().GetType());
            //foreach (var item in city.ChangeListToArray())
            //{
            //    Console.WriteLine("---");
            //    Console.WriteLine(item);
            //    Console.WriteLine("---");
            //}

            //Return value if contains or error
            //Console.WriteLine(city.DictionaryContainsValue(/*"Vilnius"*/"London"));

            //Return value if contains or error, or default T2
            //Console.WriteLine(city.DictionaryContainsValueIfNotReturnsDefault(/*"Vilnius"*/"London"));

            //Returns bool is there item in list
            //Console.WriteLine(city.IsItemInList("Vilnius"/*"London"*/));
        }
    }
}
