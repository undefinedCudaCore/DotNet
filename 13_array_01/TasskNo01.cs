namespace _13_array_01
{
    internal static class TasskNo01
    {
        internal static int[] ArrayOfPowNumbers(int[] numberArray)
        {
            int[] newNum = new int[numberArray.Length];

            for (int i = 0; i < numberArray.Length; i++)
            {
                newNum[i] = numberArray[i] * numberArray[i];
            }

            return newNum;
        }

        internal static int SumOfArrayNumbers(int[] numberArray)
        {
            int newNum = 0;

            for (int i = 0; i < numberArray.Length; i++)
            {
                newNum += numberArray[i];
            }

            return newNum;
        }

        internal static int MaxValueOfArrayElements(int[] numberArray)
        {
            int maxNumber = numberArray[0];

            for (int index = 1; index < numberArray.Length; index++)
            {
                if (numberArray[index] > maxNumber)
                    maxNumber = numberArray[index];
            }

            return maxNumber;
        }

        internal static int[] ReverseArray(int[] numberArray)
        {
            int firstCounter = 0;
            int secondCounter = numberArray.Length - 1;
            int[] reversedArray = new int[numberArray.Length];

            for (int i = 0; i < numberArray.Length; i++)
            {
                reversedArray[firstCounter] = numberArray[secondCounter];
                reversedArray[secondCounter] = numberArray[firstCounter];

                firstCounter++;
                secondCounter--;
            }

            return reversedArray;
        }
    }
}
