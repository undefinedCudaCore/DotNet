namespace _8_2_ExceptionHandlingExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExceptionHandlingExerciseOne();

            ExceptionHandlingExerciseTwo();

            //ExceptionHandlingExerciseThree();

            //ExceptionHandlingExerciseFour();
        }

        private static void ExceptionHandlingExerciseFour()
        {

            try
            {
                Console.WriteLine("Enter file name:");
                string filename = Console.ReadLine();
                string readFile = File.ReadAllText(filename);
                Console.WriteLine("File succesfully read.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (PathTooLongException ex)
            //{
            //    Console.WriteLine(ex.StackTrace);
            //}
            //catch (DirectoryNotFoundException ex)
            //{
            //    Console.WriteLine(ex.Source);
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine(ex.Data);
            //}
            //catch (UnauthorizedAccessException ex)
            //{
            //    Console.WriteLine(ex.HelpLink);
            //}
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //catch (NotSupportedException ex)
            //{
            //    Console.WriteLine(ex.TargetSite);
            //}
            //catch (SecurityException ex)
            //{
            //    Console.WriteLine(ex.Url);
            //}
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Jobs done.");
            }
        }

        private static void ExceptionHandlingExerciseThree()
        {
            try
            {
                int[] arr = { 19, 0, 75, 52 };
                //Try to generate an exception
                for (int i = -100; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Jobs done.");
            }
        }

        private static void ExceptionHandlingExerciseTwo()
        {
            //Declare an array of max index 4
            int[] arr = null;

            try
            {
                //Display values of array elements
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                //Try to access invalid index of array
                Console.WriteLine(arr[7]);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("bla bla");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                //An exception is thrown upon executing
                Console.WriteLine(ex.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Unexpected error: {exception.Message}");
            }
            finally
            {
                Console.WriteLine("Jobs done.");
            }
            //the above line
        }

        private static void ExceptionHandlingExerciseOne()
        {
            try
            {
                Console.WriteLine("Enter double: ");
                string input = Console.ReadLine();
                double inputDouble = Convert.ToDouble(input);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Unexpected error: {exception.Message}");
            }
            finally
            {
                Console.WriteLine("Jobs done.");
            }
        }
    }
}
