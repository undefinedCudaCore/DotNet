namespace _11_for
{
    internal static class IntroForLoop
    {
        internal static void Intro()
        {
            int number = 5;

            for (int i = 1; i < 10; i++)
            {
                number = number * i;
                Console.WriteLine(number);
            }
        }

        internal static void Intro2()
        {
            int maxInputNumber;
            int tempStore = 0;
            int.TryParse(Console.ReadLine(), out maxInputNumber);

            for (int i = 1; i < maxInputNumber; i++)
            {
                //Console.WriteLine(i);
                tempStore += i;
            }
            Console.WriteLine(tempStore);
        }

        internal static void Intro3()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

    }
}
