using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_while_doWhile
{
    internal class TaskNo03
    {
        internal static void ExcerciseForTaskNoThreeA()
        {
            string option = "";
            int number;
            int exitCode;

            Console.WriteLine("Iveskite sveikaji skaiciu");
            option = Console.ReadLine();

            try
            {
                if (int.Parse(option).GetType() == typeof(int))
                {
                    Console.WriteLine("Jusu sveikasis skaicius yra: " + option);
                }
            }
            catch
            {
                while (option.GetType() != typeof(int))
                {
                    Console.WriteLine("Iveskite sveikaji skaiciu");

                    option = Console.ReadLine();
                }
            }
        }

        internal static void ExcerciseForTaskNoThreeB()
        {
            Console.WriteLine("Iveskite skaiciu, kuri norite pakelti laipsniu:");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite skaiciu, kurio norite pakelti pirmaji:");
            double secondNumber = double.Parse(Console.ReadLine());

            double pow = Math.Pow(firstNumber, secondNumber);

            Console.WriteLine(@$"Jusu skaicius {firstNumber} " +
                $"pakeltas laipsniu {secondNumber} yra {Math.Round(pow, 2)}");
        }

        internal static void ExcerciseForTaskNoThreeC()
        {
            int firstIterator = 0;
            int number, group;

            try
            {
                string showGroups = "";

                Console.WriteLine("Irasykite skaiciu:");
                number = int.Parse( Console.ReadLine() );

                Console.WriteLine("Irasykite kiek turi buti grupiu");
                group = int.Parse(Console.ReadLine());

                while (firstIterator < group)
                {
                    showGroups = $" -> {number}";
                    Console.Write(showGroups);
                    firstIterator++;
                }
                Console.WriteLine(" ->");
            }
            catch
            {
                Console.WriteLine("You must enter a number!!!");
                Console.WriteLine();
            }
        }

        internal static void NumberGroup()
        {

        }
    }
}
