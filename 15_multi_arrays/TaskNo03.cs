namespace _15_multi_arrays
{
    internal class TaskNo03
    {
        public static void MultidimArrayMaxValue(int[,] array)
        {
            int[] firstArray = new int[array.GetLength(1)];
            int[] secondArray = new int[array.GetLength(1)];
            int firstMax = 0;
            int firsPosition = 0;
            int secondMax = 0;
            int secondPosition = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    firstArray[j] = array[0, j];
                    secondArray[j] = array[1, j];
                }
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (firstArray[i] < firstArray[j])
                    {
                        firstMax = firstArray[j];
                        firsPosition = j;
                    }
                }
            }

            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (secondArray[i] < secondArray[j])
                    {
                        secondMax = secondArray[j];
                        secondPosition = j;
                    }
                }
            }

            if (firstMax > secondMax)
            {
                Console.WriteLine("Reiksme: " + firstMax);
                Console.WriteLine("Pozicija: 0 /" + firsPosition);
            }
            if (firstMax < secondMax)
            {
                Console.WriteLine("Reiksme: " + secondMax);
                Console.WriteLine("Pozicija: 1 / " + secondPosition);
            }
        }

        public static void IsMultiDImArrayIsSimetrical(int[,] array)
        {

        }

        public static string[,] GetAnimalOptions(int animalQuantity)
        {
            string text;
            int count1 = 0;
            int count2 = 0;

            string[,] animalOptions = new string[animalQuantity + 1, 4];

            animalOptions[0, 0] = "Name";
            animalOptions[0, 1] = "Type";
            animalOptions[0, 2] = "Color";
            animalOptions[0, 3] = "Temper";

            for (int j = 1; j < animalOptions.GetLength(0); j++)
            {
                for (int i = 0; i < animalOptions.GetLength(1); i++)
                {
                    string columnName = animalOptions[count1, count2++].ToLower();

                    Console.WriteLine($"Enter {j} animal {columnName}:");
                    text = Console.ReadLine();
                    Console.WriteLine();

                    if (!String.IsNullOrEmpty(text) || !String.IsNullOrWhiteSpace(text))
                    {
                        animalOptions[j, i] = text;
                    }
                    else
                    {
                        return animalOptions;
                    }

                    if (count2 == 4 || count2 % 4 == 0)
                    {
                        count2 = 0;
                    }
                }
            }

            return animalOptions;
        }

        public static void PrintMultiDimnentionalStringArray(string[,] strings)
        {
            if (!String.IsNullOrEmpty(strings[strings.GetLength(0) - 1, strings.GetLength(1) - 1])
                || !String.IsNullOrWhiteSpace(strings[strings.GetLength(0) - 1, strings.GetLength(1) - 1]))
            {
                for (int i = 0; i < strings.GetLength(0); i++)
                {
                    for (int j = 0; j < strings.GetLength(1); j++)
                    {
                        Console.Write(strings[i, j].PadRight(10));
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"Entered bad information.");
            }
            Console.ReadLine();
        }

        public static void MultiDimentionalArrayStarPrint()
        {
            char[,] array = new char[4, 4];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[0, 0] != ' ' && array[0, 3] != ' ')
                    {
                        array[0, 0] = ' ';
                        array[0, 3] = ' ';
                    }

                    array[i, j] = '*';

                    if (array[3, 0] != ' ' && array[3, 3] != ' ')
                    {
                        array[3, 0] = ' ';
                        array[3, 3] = ' ';
                    }
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
