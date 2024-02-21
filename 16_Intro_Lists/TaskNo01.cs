using System.Text;

namespace _16_Intro_Lists
{
    internal class TaskNo01
    {
        public static void PrintStringLenth(List<string> strings)
        {
            foreach (string str in strings)
            {
                Console.WriteLine($"Jusu zodzio '{str}' ilgis yra: {str.Length}.");
            }

        }

        public static double FiftyElements()
        {
            double average = 0;
            List<int> result = new List<int>();

            for (int i = 0; i < 50; i++)
            {
                result.Add(RandomNumber());
                //average += result[i];
            }

            average = Math.Round(result.Average());

            return average;
        }

        public static int RandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(100);

            return randomNumber;
        }

        public static List<int> ValueBiggerThanTen(List<int> ints)
        {
            List<int> bigger = new List<int>();

            for (int i = 0; i < ints.Count; i++)
            {
                if (ints[i] > 10)
                {
                    bigger.Add(ints[i]);
                }
            }

            return bigger;
        }

        public static List<string> OddStringLength(List<string> strings)
        {
            List<string> oddLenth = new List<string>();
            byte[] asciiBytes = new byte[strings.Count];
            byte wordLentgth = 0;

            for (int i = 0; i < strings.Count; i++)
            {
                asciiBytes = Encoding.ASCII.GetBytes(strings[i]);
            }
            for (int j = 0; j < asciiBytes.Length; j++)
            {
                wordLentgth += asciiBytes[j];
                if (wordLentgth % 2 != 0)
                {
                    wordLentgth = 0;
                    oddLenth.Add(strings[j]);
                }
            }

            return oddLenth;
        }

        public static List<int> FactiorialOfList(List<int> list)
        {
            List<int> result = new List<int>();


            foreach (int item in list)
            {
                int factorial = item;
                for (int j = 1; j < item; j++)
                {
                    factorial *= j;
                }
                result.Add(factorial);
            }

            return result;
        }
    }
}
