using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_while_doWhile
{
    internal class Introduction
    {
        internal static string introString;
        internal static int introInt;

        internal static void whileIntroduction()
        {
            Console.WriteLine("Hello while loop!");
            Console.WriteLine();

            // ---------------Example No. 1---------------
            //int i = 1;
            //while (i <= 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //while (i >= 1)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            // ------------------Example No. 2 -------------------
            //int textIteration = 1;
            //string result = "";
            //while(textIteration > -5)
            //{
            //    Console.WriteLine("Iveskite teksta:");
            //    string input = Console.ReadLine();

            //    result += input + " ";
            //    textIteration--;
            //}
            //Console.WriteLine(result);

            //-------------Example No. 3 ----------------
            //int firstIterator = 1;
            //int secondIterator = 1;

            //while (firstIterator <= 3)
            //{
            //    Console.WriteLine($"Outer loop called: {firstIterator}#");

            //    while ( secondIterator <= 3 )
            //    {
            //        Console.WriteLine($"Inner loop called: {secondIterator}#");

            //        secondIterator++;
            //    }

            //    // Reset inner loop iterator
            //    secondIterator = 1;
            //    firstIterator++;
            //}

            // ---------------Example No. 4-------------------
            int option = 0;
            int mutatingNumbers = 0;
            int exitCode = 99999;

            while(mutatingNumbers < exitCode)
            {
                Console.WriteLine("1. Padidinti");
                Console.WriteLine("2. Sumazinti");
                Console.WriteLine("3. Padauginti is 2ju");
                Console.WriteLine("4. Pakelti antru laipsniu");
                Console.WriteLine("5. Iseiti");

                option = int.Parse(Console.ReadLine());
                mutatingNumbers = option switch
                {
                    1 => mutatingNumbers + 1,
                    2 => mutatingNumbers - 1,
                    3 => mutatingNumbers * 2,
                    4 => mutatingNumbers * mutatingNumbers,
                    5 => 99999,
                    _ => mutatingNumbers
                };
                Console.WriteLine("Manipulating numbers " + mutatingNumbers);
            }

            while (true)
            {
                Console.WriteLine("This is how we break up from infinity loop.");
                break;
            }
        }
    }
}
