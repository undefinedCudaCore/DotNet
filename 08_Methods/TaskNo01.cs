namespace _08_Methods
{
    internal class TaskNo01
    {
        internal static bool checkedPassword;
        internal static bool checkedEmail;
        internal static bool isChecked;
        internal static bool isNumberEvenOrOdd;
        internal static double convertedMoney;
        internal static double currency = 0.85;
        internal static string enter /*= Console.ReadLine()*/;
        internal static double fee;

        internal static void Intro()
        {
            int myInputNumber;

            bool isNumber = int.TryParse(Console.ReadLine(), out myInputNumber);

            if (isNumber)
            {
                Console.WriteLine(myInputNumber);
            }
        }

        internal static void ExerciseForTaskNoOne()
        {
            //Console.WriteLine("Enter password:");
            //Console.WriteLine(IsPasswordValid(enter));
            //Console.WriteLine();

            //Console.WriteLine("Enter email:");
            //Console.WriteLine(IsEmailValid(enter));
            //Console.WriteLine();


            //Console.WriteLine("Enter Dollar amount to change to Euros:");
            //bool enterValue = double.TryParse(enter, out fee);
            //Console.WriteLine($"You have {ConvertToEuros(fee)} euros.");
            //Console.WriteLine();

            //Console.WriteLine("Enter first name (press enter) and last name (press enter):");
            //Console.WriteLine(GetInitials(Console.ReadLine(), Console.ReadLine()));
            //Console.WriteLine();

            Console.WriteLine("Enter a number to check number is even or odd:");
            int myNumber;
            bool myInputNumber = int.TryParse(Console.ReadLine(), out myNumber);
            if (myInputNumber)
            {
                Console.WriteLine($"My number is even - {IsNumberEven(myNumber)}");
            }
            else
            {
                Console.WriteLine("This is not number!");
            }

        }

        internal static bool IsPasswordValid(string password)
        {

            if (password.ToString().Length > 8)
            {
                checkedPassword = true;
            }
            return checkedPassword;
        }

        internal static bool IsEmailValid(string email)
        {
            //bool eta = false;
            //bool dot = false;

            //for (int i = 0; i < email.Length; i++)
            //{
            if (email.Contains("@") && email.Contains("."))
            {
                checkedEmail = true;
            }
                //else if ()
                //{
                //    dot = true;
                //}
            //}
            //if (eta && dot)
            //{
            //    checkedEmail = true;
            //}
            return checkedEmail;
        }

        internal static double ConvertToEuros(double dollars)
        {
            convertedMoney = dollars * currency;

            return Math.Round(convertedMoney, 2);
        }

        internal static string GetInitials(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

        internal static bool IsNumberEven(int number)
        {

            if (number % 2 == 0)
            {
                isNumberEvenOrOdd = true;
            }
            else
            {
                isNumberEvenOrOdd = false;
            }

            return isNumberEvenOrOdd;
        }

        internal static void CheckCharInTwoStrings()
        {
            string firstInput;
            string secondInput;

            Console.WriteLine("Enter firs sentens to check similar strings:");
            firstInput = Console.ReadLine();
            firstInput.ToLower();
            Console.WriteLine();

            Console.WriteLine("Enter firs sentens to check similar strings:");
            secondInput = Console.ReadLine();
            secondInput.ToLower();
            Console.WriteLine();

            for (var i = 0; i < firstInput.Length; i++)
            {
                for (var j = 0; j < secondInput.Length; j++)
                {
                    if (firstInput[i] == secondInput[j])
                    {
                        Console.WriteLine(firstInput[i]);
                        break;
                    }
                }
            }
        }
    }
}
