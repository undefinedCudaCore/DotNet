internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("------ Uzduotis Nr. 1. ------");
        Console.WriteLine();

        //var operation = 0;

        //var result = operation switch
        //{
        //    1 => "Case 1",
        //    2 => "Case 2",
        //    3 => "Case 3",
        //    4 => "Case 4",
        //    _ => "Default case"
        //};

        //Console.WriteLine(result);

        Console.WriteLine("Iveskite savaites dienos numeri:");

        int enterNumber = int.Parse(Console.ReadLine());

        var result = enterNumber switch
        {
            1 => "Pirmadienis",
            2 => "Antradienis",
            3 => "Treciadienis",
            4 => "Ketvirtadienis",
            5 => "Penktadienis",
            6 => "Sestadienis",
            7 => "Sekmadienis",
            _ => "Tai nera savaites dienos numeris"
        };

        Console.WriteLine(result);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("Iveskite savo amziu");

        int enterAge = int.Parse(Console.ReadLine());

        switch (enterAge)
        {
            case <= 0:
                Console.WriteLine("Planuose");
                break;
            case <= 3:
                Console.WriteLine("Kudikis");
                break;
            case <= 7:
                Console.WriteLine("Ikimokiklinukas");
                break;
            case <= 18:
                Console.WriteLine("Moksleivis");
                break;
            case <= 25:
                Console.WriteLine("Studentas");
                break;
            case <= 64:
                Console.WriteLine("Darbuotojas");
                break;
            case > 65:
                Console.WriteLine("Pensininkas");
                break;
            default:
                Console.WriteLine("Nepatenkate i amziaus diapozona");
                break;
        }

        Console.WriteLine();
        Console.WriteLine("Iveskite menesio numeri:");

        int enterMonthNumber = int.Parse(Console.ReadLine());

        string monthResult = enterMonthNumber switch
        {
            1 => "Sausis",
            2 => "Vasaris",
            3 => "Kovas",
            4 => "Balandis",
            5 => "Geguze",
            6 => "Birzelis",
            7 => "Liepa",
            8 => "Rugpjutis",
            9 => "Rugsejis",
            10 => "Spalis",
            11 => "Lapkritis",
            12 => "Gruodis",
            _ => "Tai nera menesio numeris"
        };

        Console.WriteLine(monthResult);


        Console.WriteLine();
        Console.WriteLine("------ Uzduotis Nr. 2. ------");
        Console.WriteLine();

        Console.WriteLine("Iveskite geometrijos figuros pavadinima");
        string figure = Console.ReadLine();

        switch (figure)
        {
            case "Kvadratas":
                Console.WriteLine("Iveskite kvadrato krastine:");
                double kvadratoKrastine = double.Parse(Console.ReadLine());
                double kvadratoPlotas = kvadratoKrastine * kvadratoKrastine;
                Console.WriteLine($"Kvadrato plotas yra: {kvadratoPlotas}");
                break;

            case "Apskritimas":
                Console.WriteLine("Iveskite apskritimo spinduili:");
                double apskritimoSpindulys = double.Parse(Console.ReadLine());
                double apskritimoPlotas = 3.14 * (apskritimoSpindulys * apskritimoSpindulys);
                Console.WriteLine($"Apskritimo plotas yra: {apskritimoSpindulys}");
                break;

            case "Trikampis":
                Console.WriteLine("Iveskite trikampio aukstine ir pagrinda:");
                double trikampioAukstine = double.Parse(Console.ReadLine());
                double trikampioPagrindas = double.Parse(Console.ReadLine());
                double trikampioPlotas = 0.5 * (trikampioAukstine * trikampioPagrindas);
                Console.WriteLine($"Trikampio plotas yra: {trikampioPlotas}");
                break;

            case "Staciakampis":
                Console.WriteLine("Iveskite staciakampio ilgi ir ploti:");
                double staciakampioIlgis = double.Parse(Console.ReadLine());
                double staciakampioPlotis = double.Parse(Console.ReadLine());
                double staciakampioPlotas = staciakampioIlgis * staciakampioPlotis;
                Console.WriteLine($"Staciakampio plotas yra: {staciakampioPlotas}");
                break;
            default:
                Console.WriteLine("Nesurasta figura");
                break;
        }

        Console.WriteLine();
        Console.WriteLine("Pasirinkite viena is 5 elementu:");
        Console.WriteLine("Ugnis");
        Console.WriteLine("Vanduo");
        Console.WriteLine("Oras");
        Console.WriteLine("Zeme");
        Console.WriteLine("Eteris");
        Console.WriteLine();

        string element = Console.ReadLine();

        switch (element)
        {
            case "Ugnis":
                Console.WriteLine("Šis paskutinis ugnies tipas yra šiek tiek ypatingas, nes juose kalbama apie gaisrą, pradėtą ​​prieš alyvą ar riebalus, naudojamą virtuvės įrangoje.Europoje tai vadinama F klasės ugnimi, o angliškai kalbančiose teritorijose tai vadinama K klasės ugnimi (virtuve arba virtuve).Nors techniškai tai gali atitikti B klasės, tai buvo sukurta ši klasė liepsnos elgesys ir elementai, kuriuos galima naudoti gesinant, yra skirtingi (Pavyzdžiui, jo negalima išjungti anglies dioksidu). Gesinti paprastai naudojami vandens gesintuvai su tam tikrais komponentais.");
                break;

            case "Vanduo":
                Console.WriteLine("Molekulinė masė 18,016. Būna dujinės, skystosios ir kietosios būsenos. Normaliomis sąlygomis vanduo yra bespalvis, bekvapis, beskonis skystis. Kai kurios vandens savybės yra anomalios, pvz., mažinant temperatūrą kitų skysčių tankis laipsniškai mažėja, o vandens didėja ir tampa maksimalus jam užšąlant. Tai lemia nelinijinė vandens molekulės sandara: O–H ryšių kampas lygus 104,5°. Vandens molekulės yra polinės, lengvai jungiasi į asociatus. Vanduo blogai praleidžia šilumą, yra silpnas elektrolitas, nes tik labai maža dalis molekulių disocijuoja į jonus: 2H2O → H+ + OH–. Vanduo – vienas universaliausių tirpiklių, tirpina daugumą neorganinių medžiagų, dujas, nedidelės molekulinės masės organinius junginius. Reaguodamas su oksidais vanduo sudaro ir bazes, ir rūgštis, pvz., H2O + CaO → Ca(OH)2, H2O + SO2 → H2SO3.");
                break;

            case "Oras":
                Console.WriteLine("Šis straipsnis apie atmosferos dujų mišinį. Apie orus skaitykite čia. Oras – dujų mišinys, sudarantis Žemės atmosferą. Oro litro masė, jei temperatūra 0 °C");
                break;

            case "Zeme":
                Console.WriteLine("Nuo dirvožemio fizinių savybių priklauso, kiek jame susikaupia augalams reikalingų maisto medžiagų ir ar jiems užtenka vandens bei oro. Dirvožemių fizines savybes galima suskirstyti į bendrąsias ir fizines – mechanines. Bendrosioms fizinėms savybėms priskiriamas dirvožemio (kietosios dalies) tankis (lyginamasis svoris). Įvairių dirvožemių lyginamasis svoris yra nuo 1,3 iki 2,75 g/cm³.");
                break;

            case "Eteris":
                Console.WriteLine("Eteriai yra lakūs ir mažai tirpūs vandenyje. Šią jų savybę lemia tai, kad jų molekulės sudaro tik labai silpnus vandenilinius ryšius tiek su savo, tiek su vandens molekulėmis.Eteriai yra silpnai polinės medžiagos, dėl maždaug 110 laipsnių eterinio ryšio kampo ir dviejų laisvų elektronų porų prie deguonies atomo.Cikliniai eteriai yra gerai tirpūs vandenyje, nes juose eterinio ryšio kampas yra didesnis. Dėl to gali lengviau susidaryti vandeniliniai ryšiai.");
                break;

            default:
                Console.WriteLine("Pasirinkote netinkama elementa");
                break;
        }

        Console.WriteLine();
        Console.WriteLine("Iveskite viena is specialybiu pavadinimu:");
        Console.WriteLine("Matematika");
        Console.WriteLine("Informatika");
        Console.WriteLine("Biologija");
        Console.WriteLine("Chemija");
        Console.WriteLine();

        string specialybe = Console.ReadLine();

        Console.WriteLine("Iveskite pazymiu vidurki:");

        int vidurkis = int.Parse(Console.ReadLine());

        switch (specialybe)
        {
            case "Matematika":
                if (vidurkis > 6 && vidurkis !> 8)
                {
                    Console.WriteLine("Jus sansas 50 proc.");
                }
                else if (vidurkis > 9 && vidurkis !> 10)
                {
                    Console.WriteLine("Jus priimtas.");
                }
                else if (vidurkis < 6)
                {
                    Console.WriteLine("Jusu vidurkis yra per mazas.");
                }
                break;

            case "Informatika":
                if (vidurkis > 4 && vidurkis !> 8)
                {
                    Console.WriteLine("Jus sansas 80 proc.");
                }
                else if (vidurkis > 8 && vidurkis !> 10)
                {
                    Console.WriteLine("Jus priimtas.");
                }
                else if (vidurkis < 4)
                {
                    Console.WriteLine("Jusu vidurkis yra per mazas.");
                }
                break;

            case "Biologija":
                if (vidurkis > 3 && vidurkis! > 5)
                {
                    Console.WriteLine("Jus sansas 20 proc.");
                }
                else if (vidurkis > 5 && vidurkis !> 10)
                {
                    Console.WriteLine("Jus priimtas.");
                }
                else if (vidurkis < 3)
                {
                    Console.WriteLine("Jusu vidurkis yra per mazas.");
                }
                break;

            case "Chemija":
                if (vidurkis > 5 && vidurkis !> 10)
                {
                    Console.WriteLine("Jus priimtas.");
                }
                else if (vidurkis < 5)
                {
                    Console.WriteLine("Jusu vidurkis yra per mazas.");
                }
                break;

            default:
                Console.WriteLine("Vidurkis negali buti didesnis negu 10.");
                break;
        }
    }
}