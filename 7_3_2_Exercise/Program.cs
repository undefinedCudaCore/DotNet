namespace _7_3_2_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print list
            // int
            GenericClass<int> generic1 = new GenericClass<int>(new List<int>()
            {
                1,
                2,
                3,
                4
            });

            //string
            GenericClass<string> generic2 = new GenericClass<string>(new List<string>()
            {
                "A",
                "B",
                "C",
                "D"
            });

            //object
            GenericClass<ToList> generic3 = new GenericClass<ToList>(new List<ToList>()
            {
                new ToList(5),
                new ToList(58),
                new ToList(3),
                new ToList(14)
            });

            //null
            GenericClass<ToList> genericNull = new GenericClass<ToList>(null);

            //generic1.PrintList();
            //generic2.PrintList();
            //generic3.PrintList();


            //----------------------------
            //Convert to array

            //Console.WriteLine(generic1.ConvertToArray().GetType());
            //Console.WriteLine(generic2.ConvertToArray().GetType());
            //Console.WriteLine(generic3.ConvertToArray().GetType());

            //----------------------------
            ////Add to list
            //generic2.AddToOneValueToList("22");
            //generic2.PrintList();

            //----------------------------
            //Add array to list

            string[] strings = { "a", "b", "c", "d", "aa", "aa", "pp" };
            string[] strings2 = { "H", "J", "K", "L" };
            string[] strings3 = { "55", "J", "8+6", "gyf" };
            string[] strings4 = { "tt", "gdfg", "+8john6", "gyfa" };
            string[] strings1 = new string[200];

            GenericClass<Array> generic4 = new GenericClass<Array>(new List<Array>()
            {
                strings4,
                strings,
                strings,
                strings3,
                strings,
                strings,
                strings2
            });

            //generic4.AddToOneValueToList(strings3);
            //generic4.AddToOneValueToList(strings4);
            //generic4.AddToOneValueToList(strings4);

            //Remove array from list
            //generic4.RemoveOneValueFromList(strings4);
            //generic4.RemoveOneValueFromListAllValues(strings);

            //Remove array from list by index
            //generic4.RemoveOneValueFromListByIndex(0);
        }
    }
}
