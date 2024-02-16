namespace _10_ref_out
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            //Intro.Introduction();
            //Task 01.1------------------------------------

            //int one = 1;
            //int two = 2;


            //Intro.Swap(ref one, ref two);

            //Task 01.2-----------------------------------

            //int three = 0;

            //Intro.WriteGreeting("Incrementation");

            //bool checkIsNumeric = int.TryParse(Console.ReadLine(), out three);

            //if (checkIsNumeric)
            //{
            //    Intro.IncrementByN(ref three);
            //}
            //else
            //{
            //    Console.WriteLine("This is not a number.");
            //}

            //Task 01.3-----------------------------------

            //Intro.WriteGreeting("trim and capitalization");
            //string text = Console.ReadLine();
            //Intro.TrimAndCapitalize(ref text);



            //Task 02.1-----------------------------------
            string name = "tadas";
            string surename = "blinda";

            TaskNo02.GetUserData(name, surename, out name, out surename);
            Console.WriteLine($"Jusu vardas ir pavade yra {name} {surename}.");

            //Task 02.2-----------------------------------

            //TaskNo02.WhileCicle(out int numberOut);
            //Console.WriteLine(numberOut);

            //Task 02.3-----------------------------------

            //TaskNo02.Devide(out double number1, out double number2, out double remainder);
            //Console.WriteLine($"O liekana yra {remainder}.");


            //int[] intArray = { 1, 2, 3, 4, 5, 6 };

            //TaskNo02.ReverseArray(ref intArray);
        }
    }
}
