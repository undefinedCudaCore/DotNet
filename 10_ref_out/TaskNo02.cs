namespace _10_ref_out
{
    public static class TaskNo02
    {
        public static void GetUserData(string namie, string surenamie, out string name, out string surename)
        {

            //Intro.WriteGreeting("name");
            //name = Console.ReadLine();

            name = namie;

            //string inputName = Console.ReadLine();

            //Intro.WriteGreeting("surename");
            //surename = Console.ReadLine();

            surename = surenamie;

            //string InputSurename = Console.ReadLine();

            if (!String.IsNullOrEmpty(name)
                && !String.IsNullOrEmpty(surename)
                && !String.IsNullOrWhiteSpace(name)
                && !String.IsNullOrWhiteSpace(surename))
            {
                name = (name.Substring(0, 1).ToUpper()) +
                    (name.Substring(1, name.Length - 1));
                surename = (surename.Substring(0, 1).ToUpper()) +
                    (surename.Substring(1, surename.Length - 1));
            }
            else
            {
                Console.WriteLine("Check what you entered:");
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Surename: {surename}");
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

        public static double Devide(string numberString1, string numberString2, out double remainder)
        {
            remainder = 0;

            //Console.WriteLine("Enter first number:");
            bool isNumberOneNumeric = double.TryParse(numberString1, out double number1);

            //Console.WriteLine("Enter second number:");
            bool isNumberTwoNumeric = double.TryParse(numberString2, out double number2);

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
                return double.NaN;
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
