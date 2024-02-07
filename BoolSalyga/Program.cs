internal class Program
{
    private static void Main(string[] args)
    {
        //bool isOn = true;
        ////bool isOff = false;
        //bool isEnabled = true;
        //bool isAlive = true;
        //bool isSet = true;
        //bool isLogged = true;

        //// Jei mes turim skyda, mes mazinam smugi armor taskais
        //// Jei neturim skydo, 
        //bool hasShield = true;
        //int armor = 3;
        //int hitrpoints = 10;
        //int damage = 5;


        //// 1. Nebijokit perskaityti salygos garsiai;
        //// 2. Ra6ykite bool reik6mes pozytiviai;
        //// 3. Turint daugiau nei 2 salygas kelkitre jas i naujas eilutes.
        //if (!isOn 
        //    && isEnabled
        //    && isAlive
        //    && isSet)
        //{
        //    Console.WriteLine("Is on.");
        //}

        //if (isLogged)
        //{
        //    Console.WriteLine("Mes prisijungem be palyginimo");
        //}

        //if (!isLogged)
        //{
        //    Console.WriteLine("Mes prisijungem be palyginimo");
        //}

        //if(hasShield)
        //{
        //    if(armor > 0)
        //    {
        //        Console.WriteLine($"We have armor: {armor}");

        //        Console.WriteLine($"We had hp: {hitrpoints}");
        //        int currentDamage = damage - armor;
        //        hitrpoints -= currentDamage;

        //        Console.WriteLine($"Current hp: {hitrpoints}");
        //    }

        //    Console.WriteLine("We have no armor.");
        //    //Neturim armoro
        //}

        //Console.WriteLine(120%53);

        //Console.WriteLine();
        //Console.WriteLine("---------- Uzduotis Nr. 4 ----------");
        //Console.WriteLine();

        //Console.WriteLine("Enter your age:");

        //string enteredAge = Console.ReadLine();

        //if (enteredAge != "")
        //{
        //    int age = int.Parse(enteredAge);

        //    if (age < 18 && age > 0)
        //    {
        //        Console.WriteLine("Jums priklauso nepilname2io akcija");
        //    }
        //    else if (age >= 18 && age < 65)
        //    {
        //        Console.WriteLine("Jus esate suauges");
        //    }
        //    else if (age >= 65)
        //    {
        //        Console.WriteLine("Jums priklauso senioro akcija");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Amzius negali buti 0 arba mazesnis");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("You have to enter your age");
        //}


        //Console.WriteLine();
        //Console.WriteLine("---------- Uzduotis Nr. 5 ----------");
        //Console.WriteLine();



        //Console.WriteLine("Enter age:");

        //string enteredAge2 = Console.ReadLine();

        //if (enteredAge2 != "")
        //{
        //    int age = int.Parse(enteredAge2);

        //    if ((age % 4 == 0 && age % 100 != 0) 
        //        || age % 400 == 0)
        //    {
        //        Console.WriteLine("Tai yra keliamieji metai");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Tai nera keliamieji metai");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("You have to enter age");
        //}

        //Console.WriteLine();
        //Console.WriteLine("---------- Uzduotis Nr. 6 ----------");
        //Console.WriteLine();

        //try
        //{
        //    Console.WriteLine("Enter number");

        //        int parsedNumber6 = int.Parse(Console.ReadLine());

        //        if (parsedNumber6 % 3 == 0 
        //            && parsedNumber6 % 5 == 0)
        //        {
        //            Console.WriteLine("BazingaPop");
        //        }
        //        else if (parsedNumber6 % 3 == 0)
        //        {
        //            Console.WriteLine("Bazinga");
        //        }
        //        else if (parsedNumber6 % 5 == 0)
        //        {
        //            Console.WriteLine("Pop");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"You entered number {parsedNumber6}");
        //        }
        //} catch (Exception)
        //{
        //    Console.WriteLine("You have to enter a number");
        //}

        //Console.WriteLine();
        //Console.WriteLine("---------- Uzduotis Nr. 7.1. ----------");
        //Console.WriteLine();

        //try
        //{
        //    Console.WriteLine("Enter first number:");

        //    int firstNumber = int.Parse(Console.ReadLine());

        //    Console.WriteLine();
        //    Console.WriteLine("Enter second number:");

        //    int secondNumber = int.Parse(Console.ReadLine());

        //    Console.WriteLine();

        //    if (firstNumber > 0 && secondNumber > 0)
        //    {
        //        Console.WriteLine("Abu skaiciai teigiami.");
        //    }
        //    else if ((firstNumber > 0 && secondNumber < 0) || (firstNumber < 0 && secondNumber > 0))
        //    {
        //        Console.WriteLine("Tik vienas skaicius yra teisingas");
        //    }
        //    else if (firstNumber < 0 && secondNumber < 0)
        //    {
        //        Console.WriteLine("Ne vienas skaicius nera teigiamas");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Jusu skaiciai yra {firstNumber} ir {secondNumber}");
        //    }

        //}
        //catch (Exception)
        //{
        //    Console.WriteLine("You must enter number.");
        //}

        //Console.WriteLine();
        //Console.WriteLine("---------- Uzduotis Nr. 7.2. ----------");
        //Console.WriteLine();

        //try
        //{
        //    Console.WriteLine("Enter first number:");

        //    int firstNumber = int.Parse(Console.ReadLine());

        //    Console.WriteLine();
        //    Console.WriteLine("Enter second number:");

        //    int secondNumber = int.Parse(Console.ReadLine());

        //    Console.WriteLine();
        //    Console.WriteLine("Enter third number:");

        //    int thirdNumber = int.Parse(Console.ReadLine());

        //    if (firstNumber == secondNumber 
        //        && secondNumber == thirdNumber)
        //    {
        //        Console.WriteLine("Visi skaiciai yra lygus");
        //    }
        //    else if (firstNumber == secondNumber 
        //        || secondNumber == thirdNumber
        //        || firstNumber == thirdNumber)
        //    {
        //        Console.WriteLine("Du skai2iai yra lygus");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Nei vienas skaicius nera lygus");
        //    }

        //}
        //catch (Exception)
        //{
        //    Console.WriteLine("You must enter number.");
        //}

        //Console.WriteLine();
        //Console.WriteLine("---------- Uzduotis Nr. 8.1. ----------");
        //Console.WriteLine();

        //Console.WriteLine("Enter A number:");

        //int firstNumber = int.Parse(Console.ReadLine());

        //Console.WriteLine();
        //Console.WriteLine("Enter B number:");

        //int secondNumber = int.Parse(Console.ReadLine());

        //Console.WriteLine();
        //Console.WriteLine("Enter C number:");

        //int thirdNumber = int.Parse(Console.ReadLine());
        //int sum;

        //try
        //{
        //    if ((firstNumber >= 0 && secondNumber >= 0)
        //        || (secondNumber >= 0 && thirdNumber >= 0))
        //    {
        //        sum = firstNumber + secondNumber + thirdNumber;
        //        Console.WriteLine($"Skaiciu suma yra {sum}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Neimanoma suskaiciuti sumos");
        //    }
        //}
        //catch
        //{
        //    Console.WriteLine("You must enter number");
        //}

        //Console.WriteLine();
        //Console.WriteLine("---------- Uzduotis Nr. 8.2. ----------");
        //Console.WriteLine();


        //Console.WriteLine("Enter year number:");

        //int yearNumber = int.Parse(Console.ReadLine());

        //Console.WriteLine();
        //Console.WriteLine("Enter month number:");

        //int monthNumber = int.Parse(Console.ReadLine());

        //try
        //{
        //    if (monthNumber == 1 
        //        || monthNumber == 2
        //        || monthNumber == 3)
        //    {
        //        Console.WriteLine("Saltas laikotarpis");
        //    }
        //    else if (monthNumber == 6
        //        || monthNumber == 7
        //        || monthNumber == 8)
        //    {
        //        Console.WriteLine("Karstas laikotarpis");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Vidutinio laikotarpio menuo");
        //    }
        //}
        //catch
        //{
        //    Console.WriteLine("You must enter number");
        //}

        Console.WriteLine();
        Console.WriteLine("---------- Uzduotis Nr. 9. ----------");
        Console.WriteLine();

        Console.WriteLine("Iveskite tris skaicius:");

        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        try
        {
            if ((firstNumber + secondNumber > thirdNumber) 
                && (secondNumber + thirdNumber > firstNumber) 
                && (firstNumber + thirdNumber > secondNumber))
            {
                Console.WriteLine("Galima sudaryti trikampi");
            }
            else
            {
                Console.WriteLine("Negalima sudaryti trikampio");
            }
        }
        catch
        {
            Console.WriteLine("You must enter a number.");
        }

        Console.WriteLine();
        Console.WriteLine("---------- Uzduotis Nr. 10. ----------");
        Console.WriteLine();

        string milk = "Milk";
        string bread = "Bread";
        string meat = "meat";
        double milkPrice = 2.5;
        double breadPrice = 0.99;
        double meatPrice = 5.99;

        Console.WriteLine("Galima pirkti produktus:");
        Console.WriteLine($"1. {milk} - {milkPrice}");
        Console.WriteLine($"2. {bread} - {breadPrice}");
        Console.WriteLine($"3. {meat} - {meatPrice}");

        Console.WriteLine("Irasykite perkamu produktu numerius");

        string itemNumber = Console.ReadLine();
        double sum;
        double akcija = 0;

        string[] itemNumbers = itemNumber.Split(' ');

        if (itemNumbers[0] == itemNumbers[1]
                || itemNumbers[1] == itemNumbers[2]
                || itemNumbers[0] == itemNumbers[2])
        {
            akcija = 0.8;
            Console.WriteLine("Ar turite lojalumo kortele");
            string lojalumoKortele = Console.ReadLine();
            lojalumoKortele = lojalumoKortele.ToLower();

            if (lojalumoKortele == "taip")
            {
                akcija -= 0.1;
            }
            sum = (Convert.ToDouble(itemNumbers[0]) + Convert.ToDouble(itemNumbers[1]) + Convert.ToDouble(itemNumbers[2])) * akcija;
        }
        else
        {
            sum = Convert.ToDouble(itemNumbers[0]) + Convert.ToDouble(itemNumbers[1]) + Convert.ToDouble(itemNumbers[2]);
        }

        Console.WriteLine($"Suma yra: {Math.Round(sum, 2)}");

    }
}