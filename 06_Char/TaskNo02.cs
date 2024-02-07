using System.Globalization;

namespace _06_Char
{
    internal class TaskNo02
    {
        internal static string enterText;
        internal static string enterText2;
        internal static string enterText3;
        internal static string showText;

        internal static int userAge;

        internal static char[] charArray;

        internal static void TaskNoTwoA()
        {
            Console.WriteLine("Enter sentence:");
            enterText = Console.ReadLine();

            enterText = enterText.Replace("a", "uo");
            enterText = enterText.Replace("i", "e");

            Console.WriteLine(enterText);
        }

        internal static void TaskNoTwoB()
        {
            Console.WriteLine("Iveskite eilerasti arba dainos zodzius:");
            enterText = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Koki zodi norite pakeisti?");
            enterText2 = Console.ReadLine();

            Console.WriteLine($"I koki zodi norite pakeisti zodi {enterText2}?");
            enterText3 = Console.ReadLine();


            showText = enterText.Replace(enterText2, enterText3);
            Console.WriteLine(showText);
        }

        internal static void TaskNoTwoC()
        {
            int yearsLeft;
            int monthsLeft;
            int weeksLeft;
            int daysLeft;
            int weeksNow;

            Console.WriteLine("Enter your age:");
            enterText = Console.ReadLine();
            userAge = int.Parse(enterText);

            yearsLeft = 90 - userAge;

            DateTime dateOnly = DateTime.Now;
            dateOnly = dateOnly.AddYears(yearsLeft);

            yearsLeft = dateOnly.Year - 2025;
            monthsLeft = 12 - dateOnly.Month;
            weeksNow = (((dateOnly.Month - 1) * 30) + dateOnly.Day) / 7;
            weeksLeft = 52 - weeksNow;
            daysLeft = ((dateOnly.Month - 1) * 30) + dateOnly.Day;


            Console.WriteLine($"You will die in {yearsLeft} years {monthsLeft} months {weeksLeft} weeks and {daysLeft} days!!!");
        }
    }
}
