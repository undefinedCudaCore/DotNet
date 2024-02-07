using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_while_doWhile
{
    internal class TaskNo01
    {

        public static void ExcerciseForTaskNoOne()
        {
            int number = 2;

            while (number <= 10)
            {
                Console.WriteLine(number);
               number += 2;
            }

            while (number >= 3)
            {
                Console.WriteLine(number - 3);
                number -= 2;
            }
        }

        public static void ExcerciseForTaskNoOneB()
        {
            int number = 0;
            int enteredNumber;
            int numberForSecondWhile = 1;

            while (number <= 100)
            {
                Console.WriteLine("Iveskite skaiciu");

                enteredNumber = int.Parse(Console.ReadLine());
                
                Console.WriteLine();

                while (numberForSecondWhile > -1)
                {
                    Console.WriteLine("Iveskite skaiciu kol nera neigiamas");

                    enteredNumber = int.Parse(Console.ReadLine());
                    numberForSecondWhile = enteredNumber;
                    Console.WriteLine();

                }
                    numberForSecondWhile = 1;
            }
        }
    }
}
