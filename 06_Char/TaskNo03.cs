namespace _06_Char
{
    internal class TaskNo03
    {
        internal static string enterText;
        internal static string enterText2;
        internal static string enterText3;
        internal static string showText;
        internal static char[] charArray;


        internal static void TaskNoThreeA()
        {
            Console.WriteLine("Iveskite zodi:");
            enterText = Console.ReadLine();

            Console.WriteLine(enterText.Substring( 0, 1));

            if (enterText.Substring(0, 1) != enterText.Substring(0, 1).ToUpper())
            {
                Console.WriteLine(enterText.Substring(0, 1).ToUpper() + enterText.Substring(1));
            }
            else
            {
                Console.WriteLine(enterText.ToUpper());
            }
        }

        internal static void TaskNoThreeB()
        {
            Console.WriteLine("Iveskite zodi:");
            enterText = Console.ReadLine();

            if (enterText.Contains("a"))
            {
                Console.WriteLine(enterText + enterText.IndexOf('a'));
            }
            else
            {
                Console.WriteLine("Simbolis 'a' nerastas.");
            }
        }

        internal static void TaskNoThreeC()
        {
            Console.WriteLine("Iveskite zodi:");
            enterText = Console.ReadLine();
            enterText3 = enterText.ToLower();

            if (enterText3.Contains("labas"))
            {
                charArray = enterText3.ToCharArray();
                Array.Reverse(charArray);
                enterText2 = new string(charArray);
                Console.WriteLine(enterText2);
            }
            else
            {
                Console.WriteLine(enterText3);
            }
        }
    }
}
