namespace _7_1_Generic_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ShowItem<string>("Testing");

            //CustomList<int> cl = new CustomList<int>(5);
            //cl.AddToArray(66);
            //cl.AddToArray(88);
            //cl.AddToArray(89);
            //cl.AddToArray(110);
            //cl.AddToArray(118);
            //cl.AddToArray(118);
            //cl.AddToArray(118);
            //cl.AddToArray(118);
            //cl.AddToArray(118);
            //cl.AddToArray(118);
            //cl.AddToArray(118);



            //foreach (var item in cl.Array2)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine("----");
            //}

            //Exircise 1------------------------
            Validation<string> valid = new Validation<string>(null);

            //Exircise 2------------------------
            Console.WriteLine(Validation<string>.Validate("null"));
        }

        //public static void ShowItem<T>(T item)
        //{
        //    Console.WriteLine(item);
        //}

    }
}
