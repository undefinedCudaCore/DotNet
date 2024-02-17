namespace _13_array_01
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            //Intro.ArrayIntro();

            int[] arrayWithInitialValues = { 1, 2, 3, 55, 5, 6, 7, 8, 9, 10 };

            //------------------------------------------------------------------Task NO 01.1.

            //int[] newArrayWithInitialValues = TasskNo01.ArrayOfPowNumbers(arrayWithInitialValues);
            //for (int i = 0; i < newArrayWithInitialValues.Length; i++)
            //{
            //    Console.WriteLine($"The array {i} position contains powered number: {newArrayWithInitialValues[i]}");
            //}

            //------------------------------------------------------------------Task No 01.2.

            //int sumOfArrayElements = TasskNo01.SumOfArrayNumbers(arrayWithInitialValues);

            //Console.WriteLine($"Sum of array elements is: {sumOfArrayElements}");

            //------------------------------------------------------------------Task No 01.3.

            //int maxValue = TasskNo01.MaxValueOfArrayElements(arrayWithInitialValues);

            //Console.WriteLine($"Max array element number is: {maxValue}");

            //------------------------------------------------------------------Task No 01.4.

            //int[] reversed = TasskNo01.ReverseArray(arrayWithInitialValues);

            //for (int i = 0; i < reversed.Length; i++)
            //{
            //    Console.WriteLine($"The reversed array {i} position contains number: {reversed[i]}");
            //}

            //----------------------------------------------------------------

            //------------------------------------------------------------------Task NO 02.1.

            //Console.WriteLine("Enter word: ");
            //string wordToCharArray = Console.ReadLine();

            //char[] chars = TaskNo02.StringToCharArray(wordToCharArray);

            //Console.Write("{ ");

            //for (int i = 0; i < chars.Length - 1; i++)
            //{
            //    Console.Write("'" + chars[i] + "', ");
            //}
            //Console.Write("'" + chars[chars.Length - 1] + "'");
            //Console.Write(" }");


            //------------------------------------------------------------------Task NO 02.2.
            //Console.WriteLine("Enter sentence:");
            //string enteredSentence = Console.ReadLine();

            //char[] returnedFirstLetter = TaskNo02.FirstCharOfEachSentenceWord(enteredSentence);
            //string returnedFirstLetterOfEachWord = "";

            //for (int i = 0; i < returnedFirstLetter.Length; i++)
            //{
            //    returnedFirstLetterOfEachWord += returnedFirstLetter[i];
            //}

            //Console.WriteLine(returnedFirstLetterOfEachWord);

            //------------------------------------------------------------------Taks NO 02.3.

            //Console.WriteLine("Enter sentence:");
            //string enteredSentence = Console.ReadLine();

            //char[] returnedFirstLetter = TaskNo02.LastCharOfEachSentenceWord(enteredSentence);
            //string returnedFirstLetterOfEachWord = new string(returnedFirstLetter);

            //////Do not use for loop, because used new string() in 79 line;
            //////for (int i = 0; i < returnedFirstLetter.Length; i++)
            //////{
            //////    returnedFirstLetterOfEachWord += returnedFirstLetter[i];
            //////}

            //Console.WriteLine(returnedFirstLetterOfEachWord);


            ////------------------------------------------------------------------Taks NO 03.1.
            //int[] newInts = { 2, 3, 4, 8, 7, 6, 10, 9, 15, 14, 13, 1 };

            //int[] sortedInts = TaskNo03.FromLowToHighValue(newInts);

            //for (int i = 0; i < newInts.Length; i++)
            //{
            //    Console.WriteLine(sortedInts[i]);
            //}

            ////------------------------------------------------------------------Taks NO 03.2.
            //int[] sortedInts2 = TaskNo03.FromHighToLowValue(newInts);

            //for (int i = 0; i < newInts.Length; i++)
            //{
            //    Console.WriteLine(sortedInts2[i]);

            //}

            ////------------------------------------------------------------------Taks NO 03.3 - replace.
            //int[] valueArray = new int[10];
            //TaskNo03.ReplaceArrayElement(valueArray, 1058, 0);
            //TaskNo03.ReplaceArrayElement(valueArray, 5, 2);
            //TaskNo03.ReplaceArrayElement(valueArray, 45, 5);
            //TaskNo03.ReplaceArrayElement(valueArray, 867, 1);
            //TaskNo03.ReplaceArrayElement(valueArray, 22, 8);
            //TaskNo03.ReplaceArrayElement(valueArray, 45, 9);
            //TaskNo03.ReplaceArrayElement(valueArray, 12, 3);
            //TaskNo03.ReplaceArrayElement(valueArray, 1225, 6);
            //TaskNo03.ReplaceArrayElement(valueArray, 541, 4);
            //TaskNo03.ReplaceArrayElement(valueArray, 999, 7);

            //TaskNo03.FromLowToHighValue(valueArray);

            //foreach (var item in valueArray)
            //{
            //    Console.WriteLine(item);
            //}

            ////------------------------------------------------------------------Taks NO 03.3

            //int[] addedValue = TaskNo03.AddElementToIntArray(arrayWithInitialValues, 100, arrayWithInitialValues.Length);

            //for (int i = 0; i < addedValue.Length; i++)
            //{
            //    Console.WriteLine(addedValue[i]);
            //}

            ////------------------------------------------------------------------Taks NO 03.4.

            //double[] value = { 1.2, 2.2, 3.4, 4.0, 5, 8, 62 };

            //double[] removedValue = TaskNo03.RemoveElementFromArray(value, value.Length - 1);
            ////removedValue = TaskNo03.RemoveElementFromArray(value, 6);

            //for (int i = 0; i < removedValue.Length; i++)
            //{
            //    Console.WriteLine(removedValue[i]);
            //}

            ////------------------------------------------------------------------Additional task No 01.
            string textForFirstArray = "Grace ye one with but what seemed steel by consecrate " +
                "parting aye many his aught apart nine sorrow one and other he not him he monks " +
                "festal thee paphian when childe or misery days only coffined aught albions " +
                "breast sins bidding amiss than him such condemned the he childe he";
            string textForSecondArray = "He now satiety florid atonement not riot sight he muse " +
                "and one and seraphs his chaste some me what he revellers monks his riot wassailers " +
                "his womans power ive few ne one was few plain ways talethis his take suffice in " +
                "smile chaste a the are monks in such sister";

            //string[] array1 = textForFirstArray.Split(' ');
            //string[] array2 = textForSecondArray.Split(' ');

            //IEnumerable<string> returnedValue = TaskNo03.ReturnsValueWhichDoNotInTwoArrays(array1, array2);

            //foreach (string repeatedWord in returnedValue)
            //{
            //    Console.WriteLine(repeatedWord);
            //}

            ////------------------------------------------------------------------Additional task No 02.

            string[] array1 = textForFirstArray.Split(' ');
            string[] array2 = textForSecondArray.Split(' ');

            IEnumerable<string> returnedValue = TaskNo03.ReturnsValueWhichDoNotInTwoArrays(array1, array2);

            foreach (string repeatedWord in returnedValue)
            {
                Console.WriteLine(repeatedWord);
            }
        }
    }
}
