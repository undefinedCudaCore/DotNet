namespace _13_array_01
{
    internal static class TaskNo03
    {
        // Sorts int array from lowest array value to highest
        internal static int[] FromLowToHighValue(int[] ints)
        {
            int temporaryValue;

            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = 0; j < ints.Length; j++)
                {
                    if (ints[i] < ints[j])
                    {
                        temporaryValue = ints[i];
                        ints[i] = ints[j];
                        ints[j] = temporaryValue;
                    }
                }
            }

            return ints;
        }

        // Sorts int array from highest array value to lowest
        internal static int[] FromHighToLowValue(int[] ints)
        {
            int temporaryValue;

            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = i; j < ints.Length; j++)
                {
                    if (ints[i] < ints[j])
                    {
                        temporaryValue = ints[i];
                        ints[i] = ints[j];
                        ints[j] = temporaryValue;
                    }
                }
            }

            return ints;
        }
        //Relpaces arrays element.
        //Second argument is value to replace with.
        //Third argument is arrays element index.
        internal static int[] ReplaceArrayElement(int[] ints, int value, int arrayIndex)
        {
            ints[arrayIndex] = value;

            return ints;
        }

        //Relpaces arrays element.
        //Second argument is a value to add to the array.
        //Third argument is arrays element index.
        internal static int[] AddElementToIntArray(int[] ints, int value, int arrayIndex)
        {
            int[] array1 = new int[arrayIndex];
            int[] array2 = new int[ints.Length - array1.Length];
            int[] result = new int[array1.Length + array2.Length + 1];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = ints[i];
                result[i] = array1[i];
            }

            result[arrayIndex] = value;

            for (int i = 1; i <= array2.Length; i++)
            {
                array2[i - 1] = ints[array1.Length - 1 + i];
                result[array1.Length + i] = array2[i - 1];
            }


            return result;
        }

        //Removes elements from an array
        //Second argument is the value index to remove from the array.
        internal static double[] RemoveElementFromArray(double[] doubles, int arrayIndex)
        {
            //doubles = doubles.Where((value, index) => index != arrayIndex).ToArray();
            doubles[arrayIndex] = double.NaN;
            int count = 0;

            for (int i = 0; i < doubles.Length; i++)
            {
                if (double.IsNaN(doubles[i]))
                {
                    break;
                }
                count++;
            }


            double[] array1 = new double[count];
            double[] array2 = new double[doubles.Length - 1 - arrayIndex];
            double[] result = new double[array1.Length + array2.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = doubles[i];
                result[i] = array1[i];
            }
            for (int i = 1; i <= array2.Length; i++)
            {
                array2[i - 1] = doubles[array1.Length + i];
                result[array1.Length + i - 1] = array2[i - 1];
            }
            return result;
        }

        //Returns an array with values that repeats in two given arrays.
        //internal static IEnumerable<string> ReturnsValueWhichRepeatsInTwoArrays(string[] firstArray, string[] secondArray)
        //{

        //    string[] newOne = firstArray.Where(secondArray.Contains).ToArray();
        //    IEnumerable<string> result = newOne.Distinct();

        //    return result;
        //}

        //Returns an array with values that repeats in two given arrays

        internal static string[] ReturnsValueWhichRepeatsInTwoArrays2(string[] firstArray, string[] secondArray)
        {
            string[] result = new string[firstArray.Length - 1];

            //Adds 
            int count = 0;
            int count2 = 0;
            foreach (var firstItem in firstArray)
            {

                foreach (var secondItem in secondArray)
                {
                    if (firstItem == secondItem)
                    {
                        result[count++] = firstItem;
                        break;
                    }
                }
            }

            //result = result.Distinct().ToArray();

            for (int i = 0; i < result.Length; i++)
            {
                string currentElement = result[i];

                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[j] == currentElement)
                    {
                        result[j] = string.Empty;
                    }
                }
                if (!String.IsNullOrEmpty(result[i]))
                {
                    count2++;
                }
            }

            string[] result2 = new string[count2];
            count = 0;

            for (int i = 0; i < result.Length; i++)
            {
                if (!String.IsNullOrEmpty(result[i]))
                {
                    result2[count++] = result[i];
                }
            }
            return result2;
        }

        //Returns an array with values that does not repeat in two given arrays.
        internal static string[] ReturnsValueWhichDoNotInTwoArrays(string[] array1, string[] array2)
        {
            int count = 0;
            int count2 = 0;

            string[] arrayConcat = new string[array1.Length + array2.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                arrayConcat[i] = array1[i];
            }
            for (int i = 0; i < array2.Length; i++)
            {
                arrayConcat[array1.Length + i] = array2[i];
            }

            //string[] result = arrayConcat.Distinct().ToArray();

            for (int i = 0; i < arrayConcat.Length; i++)
            {
                string currentElement = arrayConcat[i];

                for (int j = i + 1; j < arrayConcat.Length; j++)
                {
                    if (arrayConcat[j] == currentElement)
                    {
                        arrayConcat[j] = string.Empty;
                    }
                }
                if (!String.IsNullOrEmpty(arrayConcat[i]))
                {
                    count2++;
                }
            }

            string[] result = new string[count2];
            count = 0;

            for (int i = 0; i < arrayConcat.Length; i++)
            {
                if (!String.IsNullOrEmpty(arrayConcat[i]))
                {
                    result[count++] = arrayConcat[i];
                }
            }
            return result;
        }

        internal static string[] EraseEmptiStringValueFromArray(string[] arrayToClearWhitespace)
        {
            int count = 0;

            for (int i = 0; i < arrayToClearWhitespace.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(arrayToClearWhitespace[i]))
                {
                    break;
                }
                count++;
            }

            string[] array1 = new string[count];
            int secondArrayLength = arrayToClearWhitespace.Length - (array1.Length + 1);
            string[] array2 = new string[secondArrayLength];
            string[] erasedResult = new string[array1.Length + array2.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = arrayToClearWhitespace[i];
                erasedResult[i] = array1[i];
            }
            for (int i = 1; i <= array2.Length; i++)
            {
                array2[i - 1] = arrayToClearWhitespace[array1.Length + i];
                erasedResult[array1.Length + i - 1] = array2[i - 1];
            }

            return erasedResult;
        }
    }
}
