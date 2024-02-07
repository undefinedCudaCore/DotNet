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
            CalculateUsingIteration(enteredNuber);
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
            int a = 0, b = 1, temp;

            for (int i = 0; i < number; i++)
            {
                temp = a;
                a = b;
                b = temp + b;
                Console.WriteLine(b);
            }

            return a;
        }
    }
}
