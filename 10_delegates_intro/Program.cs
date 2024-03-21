namespace _10_delegates_intro
{
    internal class Program
    {
        private delegate int NumberChanger(int number);
        static void Main(string[] args)
        {
            //var numberDelegate1 = new NumberChanger(AddNumber);
            //var numberDelegate2 = new NumberChanger(SubtractNumber);

            //int additionalResult1 = numberDelegate1(5);
            //int additionalResult2 = numberDelegate2(8);
        }

        public static int AddNumber(int number)
        {
            return 1 + number;
        }

        public static int SubtractNumber(int number)
        {
            return 1 - number;
        }
    }
}
