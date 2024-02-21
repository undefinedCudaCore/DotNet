namespace _16_Intro_Lists
{
    internal class Intro
    {
        public static void List()
        {
            List<string> list = new List<string>();
            List<string> strings = new List<string> { "Tadas", "Tomas", "Edgaras" };
            strings.Add("Aa");
            strings.Insert(1, "BB");

            string[] stringsArray = strings.ToArray();

            List<string> list2 = stringsArray.ToList();

            list = strings;
            Console.WriteLine();
        }

        public static void List2(int?[] ints, int value, int arrayIndex)
        {
            int?[] array1 = new int?[arrayIndex];
            int?[] array2 = new int?[ints.Length - array1.Length];
            int?[] result = new int?[array1.Length + array2.Length + 1];

            int position = -1;
            int? position2 = null;

            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] == position2)
                {
                    position = i;
                }
            }

            if (position >= 0)
            {
                ints[position] = value;

                foreach (var item in ints)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
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

                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
