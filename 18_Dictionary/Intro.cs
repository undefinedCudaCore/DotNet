namespace _18_Dictionary
{
    internal class Intro
    {
        public static void DictionaryIntro()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>
            {
                { "Vilnius", 7 },
                { "Kaunas", 6},
                { "Siauliai", 8},
                { "Jonava", 6 }
            };

            Dictionary<string, int> dict2 = new Dictionary<string, int>
            {
                { "Ieva", 7 },
                { "Andrius", 6},
                { "Siauliai", 8},
                { "Jonava", 6 }
            };

            Dictionary<string, int> dict3 = new Dictionary<string, int>();
            dict2.Add("Giedrius", 88);
            foreach (var item in dict2)
            {
                //Console.WriteLine(item);
                //Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine(dict2["Siauliai"]);

        }
    }
}
