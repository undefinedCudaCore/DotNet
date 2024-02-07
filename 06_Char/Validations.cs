namespace _06_Char
{
    internal class Validations
    {

        public static void CheckValidations()
        {
            string enterIt = Console.ReadLine();

            //Validacijos
            bool isEmpty = string.IsNullOrEmpty(enterIt);
            bool isWhiteSpace = string.IsNullOrWhiteSpace(enterIt);


            if (isEmpty || isWhiteSpace)
            {
                Console.WriteLine("Empty or have white space!");
            }
            else if (!isEmpty || !isWhiteSpace)
            {
                Console.WriteLine("Contains_" + enterIt + "_");
            }

        }
    }
}
