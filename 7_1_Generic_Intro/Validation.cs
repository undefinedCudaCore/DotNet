namespace _7_1_Generic_Intro
{
    internal class Validation<T>
    {
        public Validation(T input)
        {
            Input = input;
            PrintValidation(Input);
        }

        private T Input { get; set; }

        public static bool Validate(T variable)
        {
            if (variable != null)
            //if (Input != null)
            {
                return true;
            }
            return false;
        }

        private void PrintValidation(T variable)
        {
            Console.WriteLine(Validate(variable));
        }
    }
}
