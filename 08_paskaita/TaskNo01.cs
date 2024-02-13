namespace _08_paskaita
{
    public static class TaskNo01
    {
        public static double Sum(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double Substract(double number1, double number2)
        {
            return number1 - number2;
        }

        public static double Multiplication(double number1, double number2)
        {
            return number1 * number2;
        }

        public static double Devide(double number1, double number2)
        {
            if (number2 == 0)
            {
                return double.NaN;
            }
            else
            {
                return number1 / number2;
            }
        }

        public static double Sqrt(double number1, double number2)
        {
            if (number1 <= 0 || number2 <= 0)
            {
                return double.NaN;
            }
            else
            {
                return Math.Round(Math.Sqrt(number1 * number2), 2);
            }
        }

        public static double Pow(double number1, double number2)
        {
            return Math.Round(Math.Pow(number1, number2), 2);
        }

        public static void Menu()
        {
            Console.WriteLine("1. Enter two numbers to sum.");
            Console.WriteLine("2. Enter two numbers to substract.");
            Console.WriteLine("3. Enter two numbers to multiply.");
            Console.WriteLine("4. Enter two numbers to devide.");
            Console.WriteLine("5. Enter two numbers to found square root.");
            Console.WriteLine("6. Enter two numbers to POW.");
            Console.WriteLine("Q. Enter 'q' to stop.");
            Console.WriteLine();
            MySwitch(Console.ReadLine());
        }

        public static double UserInput(string input)
        {
            double numberForCalculator;

            bool notNumber = double.TryParse(input, out numberForCalculator);

            if (notNumber)
            {
                return numberForCalculator;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("This is not number");
                Console.WriteLine();
                Menu();
                return double.NaN;
            }
        }

        public static void MySwitch(string forSwitch)
        {
            int number;
            int.TryParse(forSwitch, out number);

            switch (number)
            {
                case 1:
                    Console.WriteLine("Enter two numbers one after other:");
                    Console.WriteLine(Sum(
                        UserInput(Console.ReadLine()),
                        UserInput(Console.ReadLine())));
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Enter two numbers one after other:");
                    Console.WriteLine(Substract(
                        UserInput(Console.ReadLine()),
                        UserInput(Console.ReadLine())));
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Enter two numbers one after other:");
                    Console.WriteLine(Multiplication(
                        UserInput(Console.ReadLine()),
                        UserInput(Console.ReadLine())));
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("Enter two numbers one after other:");
                    Console.WriteLine(Devide(
                        UserInput(Console.ReadLine()),
                        UserInput(Console.ReadLine())));
                    Console.WriteLine();
                    break;
                case 5:
                    Console.WriteLine("Enter two numbers one after other:");
                    Console.WriteLine(Sqrt(
                        UserInput(Console.ReadLine()),
                        UserInput(Console.ReadLine())));
                    Console.WriteLine();
                    break;
                case 6:
                    Console.WriteLine("Enter two numbers one after other:");
                    Console.WriteLine(Pow(
                        UserInput(Console.ReadLine()),
                        UserInput(Console.ReadLine())));
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Quit");
                    break;
            }
        }
    }
}
