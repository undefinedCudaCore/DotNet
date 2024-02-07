namespace _06_Char
{
    internal class CharArray
    {
        internal static string enterText;
        internal static string enterText2;
        internal static string showText;
        internal static char[] charArray;
        internal static char[] charArray2;
        internal static char[] charArray3 = new char[10];

        internal static void UzduotisNrVienasA()
        {
            Console.WriteLine("Enter text:");
            enterText = Console.ReadLine();

            //enterText = enterText.Replace((char) enterText[0], (char) char.ToUpper(enterText[0]));

            charArray = enterText.ToCharArray();
            charArray[0] = char.ToUpper(charArray[0]);

            enterText = new string(charArray);
            Console.WriteLine();
            Console.WriteLine(charArray);

            //Console.WriteLine(enterText);
        }

        internal static void UzduotisNrVienasB()
        {
            Console.WriteLine("Enter 10 simbol text:");
            enterText = Console.ReadLine();

            charArray = enterText.ToCharArray();
            charArray[1] = 'g';
            charArray[3] = 'b';
            charArray[5] = '*';
            charArray[7] = 'x';
            charArray[9] = 'w';

            enterText = new string(charArray);
            Console.WriteLine();
            Console.WriteLine(charArray);

        }

        internal static void UzduotisNrVienasC()
        {
            Console.WriteLine("Enter 5 simbol text:");
            enterText = Console.ReadLine();
            charArray = enterText.ToCharArray();

            if (enterText.Length == 5)
            {
                Console.WriteLine("Enter symbol for text coding:");
                enterText2 = Console.ReadLine();

                charArray3[0] = charArray[0];
                charArray3[1] = enterText2[0];
                charArray3[2] = charArray[1];
                charArray3[3] = enterText2[0];
                charArray3[4] = charArray[2];
                charArray3[5] = enterText2[0];
                charArray3[6] = charArray[3];
                charArray3[7] = enterText2[0];
                charArray3[8] = charArray[4];
                charArray3[9] = enterText2[0];

                Console.WriteLine(charArray3);

                //for (int i = 0; i < charArray3.Length; i++)
                //{
                //    charArray3[i] = charArray[i];
                //    charArray3[i + 1] = enterText2[0];
                //    i++;
                //}
                //Console.WriteLine(charArray3.Length);
                //Console.WriteLine(charArray3);
                //Console.WriteLine(charArray3.Length);
                //showText = new string(charArray3);
                //Console.WriteLine(showText);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        internal static void DateTimTest()
        {
            string userName = "BBB";
            DateTime today = DateTime.Now;
            string nameAndDate = string.Format($"{userName} date = {today}");
            Console.WriteLine(nameAndDate);

            //Validacijos
            string nulas = null;
            string whiteSpace = "   ";
            string emptyString = "";
            string emptyString2 = string.Empty;

            // Metodai patikrinti ar tuscia
            bool isEmpty = string.IsNullOrEmpty( emptyString );
            if ( isEmpty)
            {
                Console.WriteLine("Errod:Empty string found!");
            }

            //CHeck for white space
            bool isWhiteSpace = string.IsNullOrWhiteSpace( whiteSpace );
            if ( isWhiteSpace )
            {
                Console.WriteLine("Errod: White space found!");
            }
        }
    }
}
