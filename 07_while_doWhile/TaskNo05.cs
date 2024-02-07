using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _07_while_doWhile
{
    internal class TaskNo05
    {

        internal static void ExcerciseForTaskNoFiveA()
        {
            int sum = 0;
            int number;
            string enteredText;
            bool doWhile = true;

            try
            {
                DoWhile();
            }
            catch
            {

                Console.WriteLine("Turite ivesti skaiciu arba Baigti");
                DoWhile();
            }
        }

        internal static void DoWhile()
        {
            int sum = 0;
            int number;
            string enteredText;
            bool doWhile = true;

            Console.WriteLine("Iveskite skaiciu:");
            Console.WriteLine();

            do
            {
                enteredText = Console.ReadLine();
                enteredText = enteredText.ToLower();

                if (enteredText == "baigti")
                {
                    break;
                }

                number = int.Parse(enteredText);
                sum += number;
            }
            while (doWhile);

            Console.WriteLine(sum);
        }
    }
}
