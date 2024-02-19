namespace _14_foreach_multidimentional_arrays
{
    public class TaskNo01
    {
        public static int AverageOfArrayValues(int[] numbers)
        {
            int number = 0;

            foreach (int num in numbers)
            {
                number += num;
            }

            number = number / numbers.Length;

            return number;
        }

        public static int[] ArrayOfPositiveValues(int[] numbers)
        {
            int count1 = 0;
            int count2 = 0;

            foreach (int item in numbers)
            {
                if (item > 0)
                {
                    count2++;
                }
            }

            int[] positiveNumbers = new int[count2];

            foreach (int num in numbers)
            {
                if (num > 0)
                {
                    positiveNumbers[count1++] = num;
                }
            }

            return positiveNumbers;
        }

        public static double[] GPMPercentage(int[] gpm)
        {
            double[] gpmPercentageValue = new double[gpm.Length];
            int count = 0;

            foreach (int value in gpm)
            {
                gpmPercentageValue[count++] = Math.Round(value * 0.15, 2);
            }

            return gpmPercentageValue;
        }

        public static string[] StringArrayWithValueLongerThanFiveChars(string sentence)
        {
            string[] words = sentence.Split(' ');
            int count1 = 0;
            int count2 = 0;

            foreach (var word in words)
            {
                if (word.Length > 5)
                {
                    count2++;
                }
            }

            string[] words2 = new string[count2];

            foreach (string word in words)
            {
                if (word.Length > 5)
                {
                    words2[count1++] = word;
                }
            }

            return words2;
        }

        public static string[,] ConstructDeck(string[] types, string[] cards)
        {
            string[,] deck = new string[types.Length, cards.Length];

            for (int i = 0; i < types.Length; i++)
            {
                for (int j = 0; j < cards.Length; j++)
                {
                    deck[i, j] = types[i] + " " + cards[j];
                }
            }
            return deck;
        }

        public static void PrintDeck(string[,] deck)
        {
            Console.WriteLine("-------------------");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(deck[i, j]);
                }
                Console.WriteLine("-------------------");
            }
        }
    }
}
