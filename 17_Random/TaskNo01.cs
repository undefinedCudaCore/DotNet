namespace _17_Random
{
    internal class TaskNo01
    {
        public static void RandomTen()
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1, 11));
            }
        }

        public static void RandomBool()
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                bool t;
                int rnd = random.Next(1, 3);
                if (rnd == 2)
                {
                    t = true;
                    Console.WriteLine(t);

                }
                else if (rnd == 1)
                {
                    t = false;
                    Console.WriteLine(t);
                }
            }
        }

        public static void RandomChar()
        {
            Random random = new Random();
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            int rnd = random.Next(1, alpha.Length);

            Console.WriteLine(alpha[rnd]);

            string generatedPassword = "";

            for (int i = 0; i < 15; i++)
            {
                rnd = random.Next(1, alpha.Length);
                generatedPassword += alpha[rnd];
            }

            Console.WriteLine(generatedPassword);
        }

        public static void RandomInput()
        {
            Random random = new Random();
            int rnd = random.Next(1, 100);
            bool notEmpty = false;

            Console.WriteLine("SUGENERUOTAS SKAICIUS");
            Console.WriteLine("Ar skaicius didesnis ar mazesnis negu 50? Irasykite Taip / Ne.");

            string spejimas = Console.ReadLine();

            if (!String.IsNullOrEmpty(spejimas))
            {
                notEmpty = true;
            }
            if (spejimas.ToLower() == "taip" && notEmpty)
            {
                if (rnd > 50)
                {
                    Console.WriteLine("Jus atspejote");
                    Console.WriteLine("Jusu skaicius" + rnd);
                }
                if (rnd < 50)
                {
                    Console.WriteLine("Spejamas skaicius per mazas");
                }
            }
            if (spejimas.ToLower() == "ne" && notEmpty)
            {
                if (rnd > 50)
                {
                    Console.WriteLine("Spejamas skaicius per didelis");
                }
                if (rnd < 50)
                {
                    Console.WriteLine("Jus atspejote");
                    Console.WriteLine("Jusu skaicius" + rnd);
                }
            }
        }
    }
}
