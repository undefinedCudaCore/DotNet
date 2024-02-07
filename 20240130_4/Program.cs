internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Enter number:");
        //int number = int.Parse(Console.ReadLine());

        //if (number > 100)
        //{
        //    Console.WriteLine("Number is bigger than 100.");
        //}
        //else if (number == 100)
        //{
        //    Console.WriteLine("Number equals to 100.");
        //} else
        //{
        //    Console.WriteLine("Number is lower than 100");
        //}


        //Console.WriteLine("Enter day number from 1 to 7:");
        //int dayNumber = int.Parse(Console.ReadLine());

        //switch (dayNumber)
        //{
        //    case 1: Console.WriteLine("Pirmadienis");
        //        break;

        //    case 2: Console.WriteLine("Antradienis");
        //        break;

        //    case 3: Console.WriteLine("Treciadienis");
        //        break;

        //    case 4: Console.WriteLine("Ketvirtadienis");
        //        break;

        //    case 5: Console.WriteLine("Penktadienis");
        //        break;

        //    case 6: Console.WriteLine("Sestadienis");
        //        break;

        //    case 7: Console.WriteLine("Sekmadienis");
        //        break;

        //    default: Console.WriteLine("Entered bad number.");
        //        break;
        //}

        Console.WriteLine();
        Console.WriteLine("Enter number:");

        string numberString = Console.ReadLine();

        if (numberString != "")
        {
            int number = int.Parse(numberString);

            

            if (number % 2 == 0 
                && number % 5 == 0 
                && number != 0 
                && number > 0)
            {
                Console.WriteLine("Skaicius yra lyginis.");
                Console.WriteLine("Skaicius dalijasi is 5.");
            }
            else if (number % 5 == 0 && number != 0 && number > 0)
            {
                Console.WriteLine("Skaicius dalijasi is 5.");

            }
            else if (number % 2 == 0 && number != 0 && number > 0)
            {
                Console.WriteLine("Skaicius yra lyginis.");
            }
            else if (number <= -1)
            {
                Console.WriteLine("Skaicius neatitinka salygu.");
            }
            else
            {
                Console.WriteLine("Skaicius neatitinka jokiu salygu.");
            }
        }
        else
        {
            Console.WriteLine("I asked for number not for empty string.");
        }

        Console.WriteLine();
        Console.WriteLine("Enter password");

        string password = Console.ReadLine();

        string savedPassword = "Atlas";

        if (password == "Mellon")
        {
            Console.WriteLine("Sekmingai prisijungete");
        }
        else if (password == "01101001 01101110")
        {
            Console.WriteLine("Nulauzta");
        }
        else if (password == savedPassword)
        {
            Console.WriteLine("Sekmingai prisijungete");
        }
        else 
        {
            Console.WriteLine("Slaptazodis neteisingas, prasome bandyti dar karta");
        }
    }
}