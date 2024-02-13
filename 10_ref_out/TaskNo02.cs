namespace _10_ref_out
{
    public static class TaskNo02
    {
        public static void GetUserData(out string name, out string surename)
        {
            name = "";
            surename = "";

            Intro.WriteGreeting("name");
            string isStringOne = Console.ReadLine();

            Intro.WriteGreeting("surename");
            string isStringTwo = Console.ReadLine();

            if (!String.IsNullOrEmpty(isStringOne)
                && !String.IsNullOrEmpty(isStringTwo)
                && !String.IsNullOrWhiteSpace(isStringOne)
                && !String.IsNullOrWhiteSpace(isStringTwo))
            {
                name = (isStringOne.Substring(0, 1).ToUpper()) +
                    (isStringOne.Substring(1, isStringOne.Length - 1));
                surename = (isStringTwo.Substring(0, 1).ToUpper()) +
                    (isStringTwo.Substring(1, isStringTwo.Length - 1));

                Console.WriteLine($"Jusu vardas ir pavade yra {name} {surename}.");
            }
            else
            {
                Console.WriteLine("Check what you entered:");
                Console.WriteLine($"Name: {isStringOne}");
                Console.WriteLine($"Surename: {isStringTwo}");
            }
        }

        internal static void WhileLoop(out int numberOut)
        {
            bool cicle = true;
            numberOut = 0;

            while (cicle)
            {
                Console.WriteLine("Įrašykite skaičių:");

                bool checkIsNumeric = int.TryParse(Console.ReadLine(), out numberOut);

                if (checkIsNumeric && numberOut < 100)
                {
                    Console.WriteLine($"Converted to number is {checkIsNumeric}!");
                    Console.WriteLine($"Converted number is: {numberOut}!");
                }
                else
                {
                    Console.WriteLine("Neteisinga ivestis arba nurodete skaiciu ligu arba didesni negu 100.");
                    cicle = false;
                }
            }
        }

        internal static double Devide(out double number1, out double number2, out double remainder)
        {
            remainder = 0;

            Console.WriteLine("Enter first number:");
            bool isNumberOneNumeric = double.TryParse(Console.ReadLine(), out number1);

            Console.WriteLine("Enter second number:");
            bool isNumberTwoNumeric = double.TryParse(Console.ReadLine(), out number2);

            double devision = number1 / number2;

            if (number2 != 0
                && isNumberOneNumeric
                && isNumberTwoNumeric)
            {
                remainder = Math.Round(number1 % number2, 2);
                number1 = Math.Round(devision, 2);

                Console.WriteLine($"Dalmuo yra {number1}");

                return number1;
            }
            else
            {
                Console.WriteLine("Dalyba is 0 negalima.");
                return -1;
            }
        }

        internal static void ReverseArray(ref int[] array)
        {
            int firstIndex = 0;
            int lastIndex = array.Length - 1;
            //array = new int[array.Length];

            while (firstIndex < lastIndex)
            {
                int temp = array[firstIndex];
                array[firstIndex] = array[lastIndex];
                array[lastIndex] = temp;
                firstIndex++;
                lastIndex--;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
