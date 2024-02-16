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

        //Removes element from array
        //Second argument is  value index to remove from array.
        internal static double[] RemoveElementFromArray(double[] doubles, int arrayIndex)
        {
            doubles = doubles.Where((value, index) => index != arrayIndex).ToArray();

            return doubles;
        }
    }
}
