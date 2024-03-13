namespace _08_Methods
{

    internal class TaskNo02
    {
        internal static void ExerciseForTaskNoTwo()
        {
            Console.WriteLine("Enter number");
            int enteredNuber;
            bool parsedNumber = int.TryParse(Console.ReadLine(), out enteredNuber);

            //Console.WriteLine($"Your faktorial is: {ClaculateFactorial(enteredNuber)}");
            Console.WriteLine(CalculateUsingIteration(enteredNuber));
        }

        internal static int ClaculateFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * ClaculateFactorial(number - 1);
        }

        public static int CalculateUsingIteration(int number)
        {
            if(number <= 2)
            {
                return 1;
            }
            else
            {
                return CalculateUsingIteration(number - 1) + CalculateUsingIteration(number - 2);
            }
        }
    }
}
