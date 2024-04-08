namespace _7_1_Generic_Intro
{
    internal class Validation
    {
        public Validation(int input)
        {
            Input = input;
            PrintValidation(Input);
        }

        private int Input { get; set; }

        public static bool Validate<T>(T variable)
        {
            if (variable != null)
            //if (Input != null)
            {
                return true;
            }
            return false;
        }

        private void PrintValidation<T>(T variable)
        {
            Console.WriteLine(Validate<T>(variable));
        }

        public static void ShowValues<T1, T2>(T1 variable1, T2 variable2)
        {
            Console.WriteLine(variable1 + " " + variable1.GetType());
            Console.WriteLine(variable2 + " " + variable2.GetType());
        }
    }
}
