namespace _07_while_doWhile
{
    internal class TaskNo04
    {
        internal static void ExcerciseForTaskNoFour()
        {
            Console.WriteLine("Irasykite skaiciu");
            Console.WriteLine();

            int number = int.Parse(Console.ReadLine());
            int count = number;
            int character = 1;
            string character2 = $"{character} ";


            while (count > 0)
            {
                Console.WriteLine(character2);
                character2 += $"{character} ";
                character++;

                count--;
            }
        }
    }
}
