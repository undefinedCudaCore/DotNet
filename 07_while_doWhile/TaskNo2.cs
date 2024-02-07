using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_while_doWhile
{
    internal class TaskNo2
    {
        internal static void ExcerciseForTaskNoTwoA()
        {
            Console.WriteLine("Enter number for factorial");
            int number = int.Parse(Console.ReadLine());
            int i = 1;
            long factorial = number;
            while (number > 1)
            {
                factorial *= --number;

                if (number > 0)
                {
                    Console.WriteLine("{0}. {1} * {2} = {3}", i++, factorial / number, number, factorial);
                }
            }
            Console.WriteLine(factorial);
        }

        internal static void ExcerciseForTaskNoTwoB()
        {
            Console.WriteLine("Iveskite skaiciu:");
            string enteredNumber = Console.ReadLine();
            int charArrayIndex = 0;
            int charArrayLength = enteredNumber.Length;

            while (charArrayLength > 0)
            {
                Console.WriteLine(enteredNumber[charArrayIndex++]);
                charArrayLength--;
            }
        }

        internal static void ExcerciseForTaskNoTwoC()
        {
            Console.WriteLine("Iveskite kiek eiluciu nupiesti");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int count = number;
            string character = "*";

            while (count > 0)
            {
                Console.WriteLine(character);
                character += "*";
                count--;
            }
        }
    }
}
