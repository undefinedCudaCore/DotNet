using System;

namespace _13_array_01
{
    internal static class TaskNo03
    {
        // Sorts int array from lowest arrays value to highiest
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

        // Sorts int array from highiest arrays value to lowest
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
        //Second argument is value to replace whith.
        //Third argument is arrays element index.
        internal static int[] ReplaceArrayElement(int[] ints, int value, int arrayIndex)
        {
            ints[arrayIndex] = value;

            return ints;
        }

        //Relpaces arrays element.
        //Second argument is value to add into array.
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

        //Removes element from array
        //Second argument is  value index to remove from array.
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

        //Returns array whith values, that repeats in two given arrays
        internal static string[] ReturnsValueWgichRepeatsInTwoArrays(string[] firstArray, string[] secondArray)
        {
            string[] repeatedValue = new string[firstArray.Length];

            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (firstArray[i] == secondArray[j])
                    {
                        repeatedValue[i] = secondArray[j];
                    }
                }
            }


            return repeatedValue;
        }
    }
 }
