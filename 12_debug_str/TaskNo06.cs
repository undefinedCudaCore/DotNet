using System.Text;

namespace _12_debug_str
{
    internal static class TaskNo06
    {
        internal static void ReverseStringWithStringBuilder()
        {
            Console.WriteLine("Enter sentence:");
            string userInput = Console.ReadLine();
            //char[] chars = userInput.ToCharArray();

            StringBuilder stringBuilder = new StringBuilder();

            if (!String.IsNullOrEmpty(userInput) && !String.IsNullOrWhiteSpace(userInput))
            {
                for (int i = userInput.Length - 1; i >= 0; i--)
                {
                    stringBuilder.Append(userInput[i]);
                }

                Console.WriteLine($"Apversta eilute: {stringBuilder}");
            }
            else
            {
                Console.WriteLine("Wrong input. Repeat.");
            }
        }

        internal static void EliminateDublicateChars()
        {
            Console.WriteLine("Enter sentence:");
            string userInput = Console.ReadLine();
            char[] chars = userInput.ToLower().ToCharArray();

            StringBuilder stringBuilder = new StringBuilder();

            if (!String.IsNullOrEmpty(userInput) && !String.IsNullOrWhiteSpace(userInput))
            {
                chars = chars.Distinct().ToArray();
                stringBuilder.Append(chars);
                Console.WriteLine($"Eilute be dublicatu: {stringBuilder}");
            }
            else
            {
                Console.WriteLine("Wrong input. Repeat.");
            }

        }

    }
}
