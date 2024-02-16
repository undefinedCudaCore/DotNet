namespace _13_array_01
{
    internal static class TaskNo02
    {
        internal static char[] StringToCharArray(string word)
        {
            char[] charArray = word.ToCharArray();

            return charArray;
        }

        internal static char[] FirstCharOfEachSentenceWord(string sentence)
        {

            char[] charArray = sentence.ToCharArray();

            char[] chars = new char[charArray.Length];

            chars[0] = charArray[0];
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == ' ')
                {
                    chars[i + 1] = charArray[i + 1];
                }
            }
            return chars;
        }

        internal static char[] LastCharOfEachSentenceWord(string sentence)
        {
            char[] charArray = sentence.ToCharArray();

            char[] chars = new char[charArray.Length];

            chars[charArray.Length - 1] = charArray[charArray.Length - 1];
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == ' ')
                {
                    chars[i - 1] = charArray[i - 1];
                }
            }
            return chars;
        }
    }
}
