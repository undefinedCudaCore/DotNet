namespace _18_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro.DictionaryIntro();

            // -------------------------- 01.1.
            //TaskNo01.NamesAndAge();

            // -------------------------- 01.2.
            //Console.WriteLine("Please enter country: ");
            //string enterValue = TaskNo01.EnterCountry();
            //string capitalOfCountry = TaskNo01.CountryCapital(enterValue);
            //Console.WriteLine(capitalOfCountry);

            // -------------------------- 01.3.
            //Console.WriteLine("Enter fruit title to add to list: ");
            //string fruitTitle = Console.ReadLine();
            //Console.WriteLine("Enter fruit quantity to add to list: ");
            //string fruitQty = Console.ReadLine();

            //Dictionary<string, int> returnedListOfFruitsToPrint =
            //    TaskNo01.AddOrRenewFruitList(TaskNo01.FruitsTitleAndQty(), fruitTitle, fruitQty);

            //Console.WriteLine();
            //TaskNo01.PrintFruits(returnedListOfFruitsToPrint);

            // -------------------------- 01.4.
            Console.WriteLine("Enter student name: ");
            string name = Console.ReadLine();

            if (!String.IsNullOrEmpty(name))
            {
                Dictionary<string, List<int>> keyValuePairs = TaskNo01.GetStudentGrades(name);
                TaskNo01.PrintGrade(keyValuePairs, name);
            }


        }
    }
}
