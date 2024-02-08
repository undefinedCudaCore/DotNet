using System.Security.Cryptography.X509Certificates;

namespace _08_paskaita
{
    public class TaskNo01
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
            return number1 / number2;
        }

        public static double Sqrt(double number1, double number2)
        {
            return Math.Round(Math.Sqrt(number1 * number2), 2);
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

        public static double UserEnteredNumber(string input)
        {
            double numberForCalculator;

            bool notNumber = double.TryParse(input, out numberForCalculator);

            if(notNumber)
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

            switch(number)
            {
                case 1:
                    Console.WriteLine("Enter two numbers one after other:");
                    Console.WriteLine(Sum(
                        UserEnteredNumber(Console.ReadLine()), 
                        UserEnteredNumber(Console.ReadLine())));
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Enter two numbers one after other:");
                    Console.WriteLine(Substract(
                        UserEnteredNumber(Console.ReadLine()), 
                        UserEnteredNumber(Console.ReadLine())));
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Enter two numbers one after other:");
                    Console.WriteLine(Multiplication(
                        UserEnteredNumber(Console.ReadLine()), 
                        UserEnteredNumber(Console.ReadLine())));
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("Enter two numbers one after other:");
                    Console.WriteLine(Devide(
                        UserEnteredNumber(Console.ReadLine()), 
                        UserEnteredNumber(Console.ReadLine())));
                    Console.WriteLine();
                    break;
                case 5:
                    Console.WriteLine("Enter two numbers one after other:");
                    Console.WriteLine(Sqrt(
                        UserEnteredNumber(Console.ReadLine()), 
                        UserEnteredNumber(Console.ReadLine())));
                    Console.WriteLine();
                    break;
                case 6:
                    Console.WriteLine("Enter two numbers one after other:");
                    Console.WriteLine(Pow(
                        UserEnteredNumber(Console.ReadLine()), 
                        UserEnteredNumber(Console.ReadLine())));
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Quit");
                    break;
            }
        }
    }
}
