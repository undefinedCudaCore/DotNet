namespace _15_multi_arrays
{
    internal class TaskNo01
    {
        public static void EnterRowsAndCollumnsQuantity(int rows, int columns)
        {
            int[,] ints = new int[rows, columns];

            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i, j] = (i + 1) + j;
                }
            }

            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    Console.Write(ints[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void RepeatedValuesInMultiArray(int[,] ints)
        {
            int[] firstArray = new int[ints.GetLength(1)];
            int[] secondArray = new int[ints.GetLength(1)];

            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    firstArray[j] = ints[0, j];
                    secondArray[j] = ints[1, j];
                }
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (firstArray[i] == secondArray[j])
                    {
                        Console.WriteLine(firstArray[i]);
                    }
                }
            }
        }

        public static void RepeatedVNamesInMultiArray(string[,] names)
        {
            string[] firstArray = new string[names.GetLength(1)];
            string[] secondArray = new string[names.GetLength(1)];

            for (int i = 0; i < names.GetLength(0); i++)
            {
                for (int j = 0; j < names.GetLength(1); j++)
                {
                    firstArray[j] = names[0, j];
                    secondArray[j] = names[1, j];
                }
            }

            firstArray = firstArray.Distinct().ToArray();

            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (firstArray[i] == secondArray[j])
                    {
                        Console.WriteLine(firstArray[i]);
                    }
                }
            }
        }

        public static void MultiplyTwoMultidimentionalArrays(int[,] array1, int[,] array2)
        {
            int m = array1.GetLength(0);
            int q = array2.GetLength(1);
            int n = array1.GetLength(1);

            if (m == q)
            {
                int[,] multipliedTwoDArray = new int[m, q];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < q; j++)
                    {
                        multipliedTwoDArray[i, j] = 0;
                        for (int k = 0; k < n; k++)
                        {
                            multipliedTwoDArray[i, j] += array1[i, k] * array2[k, j];
                        }
                    }
                }

                Console.WriteLine("The multiplication of the two matrices is :");

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(multipliedTwoDArray[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("The multiplication of the two matrices is not possible.");
            }
        }
    }
}
