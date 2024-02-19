namespace _14_foreach_multidimentional_arrays
{
    public class Intro
    {
        internal static void Introduction()
        {
            string[] strings = new string[] { "audi", "bmw", "vplvo1" };
            string[] strings2 = new string[] { "audi", "abmw", "vplvo1" };

            foreach (string item in strings)
            {
                if (strings.Contains("audi"))
                {
                    Console.WriteLine(item);
                    break;
                }
            }

            foreach (string item in strings2)
            {
                if (strings2.Contains("a"))
                {
                    Console.WriteLine(item);
                }
            }
        }
        internal static void Introduction2()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        internal static void Introduction3()
        {

            string[] userNames = new string[] { "Tadas", "Tomas", "Elizabeth" };

            foreach (string item in userNames)
            {
                if (userNames.Contains("Elizabeth"))
                {
                    Console.WriteLine(item);
                }
            }
        }

        internal static void PrintSpecialCharacters()
        {
            char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e' };

            foreach (char letter in letters)
            {
                if (letter == 'e')
                {
                    Console.WriteLine($"Found letter {letter}. YEY.");
                }
                else
                {
                    Console.WriteLine($"Current letter value was not found {letter}. Still searching.");
                }
            }
        }

        public static int[] SquarreNumbers(int[] numbers)
        {
            int[] resultNumbers = new int[numbers.Length];
            int numberIndex = 0;

            foreach (var number in numbers)
            {
                resultNumbers[numberIndex++] = number * number;
            }

            return resultNumbers;
        }

        internal static void Print(int[] resultNumbers)
        {
            foreach (var resNum in resultNumbers)
            {
                Console.WriteLine(resNum);
            }
        }
        internal static void PrintStrings(string[] strings)
        {
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }
        internal static void PrintDoubles(double[] resultNumbers)
        {
            foreach (double resNum in resultNumbers)
            {
                Console.WriteLine(resNum);
            }
        }

    }
}
