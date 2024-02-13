namespace _11_for
{
    internal static class TaskNo01
    {
        internal static void PrintEvenNumbers()
        {
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        internal static void PrintSumOfNumbersFromInput()
        {
            Console.WriteLine("Enter number to sum it:");

            int inputNumber;
            int maxNumber = 0;
            bool isNumeric = int.TryParse(Console.ReadLine(), out inputNumber);

            if (isNumeric)
            {
                for (int i = 0; i <= inputNumber; i++)
                {
                    maxNumber += i;
                }
                Console.WriteLine($"Your sum is: {maxNumber}");
            }
            else
            {
                Console.WriteLine("Bad input!");
            }
        }

        internal static void SquareOfInputNumber()
        {
            Console.WriteLine("Enter number to get square:");

            bool isNumeric = int.TryParse(Console.ReadLine(), out int inputNumber);

            if (isNumeric)
            {
                for (int i = 1; i <= inputNumber; i++)
                {
                    Console.WriteLine(Math.Pow(i, 2));
                }
            }
            else
            {
                Console.WriteLine("Bad input!");
            }
        }

        internal static void ArithmeticMeanFromEnteredNumber()
        {
            Console.WriteLine("Enter number to Arithmetic mean:");

            int inputNumber;
            double maxNumber = 0;
            bool isNumeric = int.TryParse(Console.ReadLine(), out inputNumber);

            if (isNumeric)
            {
                for (int i = 1; i <= inputNumber; i++)
                {
                    maxNumber += i;
                }
                maxNumber = maxNumber / inputNumber;

                Console.WriteLine($"Your sum is: {maxNumber}");
            }
            else
            {
                Console.WriteLine("Bad input!");
            }
        }

        internal static void CharSimbolColumn()
        {
            Console.WriteLine("Enter number to get Tree:");

            bool isNumeric = int.TryParse(Console.ReadLine(), out int inputNumber);

            if (isNumeric)
            {

                for (int i = 0; i < inputNumber; i++)
                {
                    //for (int j = 0; j < i + 1; j++)
                    //{
                    Console.Write('*');
                    //}
                    Console.WriteLine();
                }
            }
        }

        internal static void ModuloThree()
        {
            for (int i = 3; i < 100; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        internal static void ChristmassTree()
        {
            Console.WriteLine("Enter desired height:");

            bool isNumeric = int.TryParse(Console.ReadLine(), out int n);

            if (isNumeric)
            {
                for (int i = 0; i <= n; i++)
                {
                    string stars = new string('*', i);
                    string spaces = new string(' ', n - i);
                    Console.Write(spaces);
                    Console.Write(stars);
                    if (i == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write("*");
                    if (i == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(stars);
                    Console.WriteLine(spaces);
                }
            }
        }

        internal static void NumericTree()
        {
            Console.WriteLine("Enter number to get Numeric tree:");

            bool isNumeric = int.TryParse(Console.ReadLine(), out int inputNumber);

            if (isNumeric)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                for (int i = 0; i < inputNumber + 1; i++)
                {
                    for (int j = 1; j < i + 1; j++)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        internal static void AlphabeticTree()
        {
            Console.WriteLine("Enter number to get Numeric tree:");

            string input = Console.ReadLine();
            string text = "abcdefghijklmnopqrstuvwxyz";
            int indexOfChar = text.IndexOf(input);
            string substractedString = text.Substring(0, indexOfChar + 1);

            if (!String.IsNullOrEmpty(input) && !String.IsNullOrWhiteSpace(input))
            {
                for (int i = 0; i < substractedString.Length; i++)
                {
                    for (int j = 0; j < i + 1; j++)
                    {
                        Console.Write(substractedString[j]);
                    }
                    Console.WriteLine();
                }
            }
        }

        internal static void RhombusTree()
        {
            Console.WriteLine("Enter desired height:");

            int counter = 0;
            bool isNumeric = int.TryParse(Console.ReadLine(), out int n);

            if (isNumeric)
            {
                for (int i = 0; i <= n; i++)
                {
                    string stars = new string('*', i);
                    string spaces = new string(' ', n - i);
                    Console.Write(spaces);
                    Console.Write(stars);
                    if (i == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write("*");
                    if (i == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(stars);
                    Console.WriteLine(spaces);

                    counter++;
                }
                if (counter >= n)
                {
                    for (int i = n - 1; i >= 0; i--)
                    {
                        string stars = new string('*', i);
                        string spaces = new string(' ', n - i);
                        Console.Write(spaces);
                        Console.Write(stars);
                        if (i == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.Write("*");
                        Console.Write(stars);
                        Console.WriteLine(spaces);
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        internal static void CountReapitedCharsInString()
        {
            int counter = 0;

            Console.WriteLine("Enter sentence:");
            string sentenceInput = Console.ReadLine();
            char[] chars = sentenceInput.ToLower().ToCharArray();

            Console.WriteLine("Enter letter:");
            string charInput = Console.ReadLine();


            if (!String.IsNullOrWhiteSpace(sentenceInput)
                && !String.IsNullOrWhiteSpace(charInput)
                && !String.IsNullOrEmpty(sentenceInput)
                && !String.IsNullOrEmpty(charInput))
            {
                for (int i = 0; i < sentenceInput.Length; i++)
                {
                    if (charInput.ToLower()[0] == chars[i])
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"Your letter repeats {counter} times.");
            }
            else
            {
                Console.WriteLine("Check what you entered.");
            }
        }
    }
}
