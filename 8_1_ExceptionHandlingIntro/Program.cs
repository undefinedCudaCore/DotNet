namespace _8_1_ExceptionHandlingIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExeptionHandling1();
            //ExceptionHandling2();
            //ExceptionHandling3();

            var authService = new AuthenticationService();

            try
            {
                authService.Login("admin ", "password123");
            }
            catch (InvalidLoginException ex)
            {
                Console.WriteLine($"Login failed: {ex}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error ocured: {ex.Message}");
            }
        }

        private static void ExceptionHandling3()
        {
            try
            {
                Console.WriteLine("Enter the name of file to read");
                string filename = Console.ReadLine();
                string content = File.ReadAllText(filename);
                Console.WriteLine("File content succ. read.");

                Console.WriteLine("Enter number to multiply the file size by:");
                string input = Console.ReadLine();
                int multiplier = int.Parse(input);
                Console.WriteLine($"The file size multiplied by your number is: {content.Length * multiplier}.");

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: File not found.");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Not correct input.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: An unexpected error.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Convertion attempted.");
            }
        }

        private static void ExceptionHandling2()
        {

            try
            {
                string input = "ABC";
                int result = int.Parse(input);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Incorrect format.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Convertion attempted.");
            }
        }

        private static void ExeptionHandling1()
        {
            try
            {
                int numerator = 10;
                int denominator = 0;
                int quetient = numerator / denominator;

                Console.WriteLine(quetient);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot devide by zero.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Operation attempted.");
            }
        }
    }
}