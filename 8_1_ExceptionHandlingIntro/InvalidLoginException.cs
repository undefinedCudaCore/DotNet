namespace _8_1_ExceptionHandlingIntro
{
    internal class InvalidLoginException : Exception
    {
        public InvalidLoginException() : base("Invalid login credentials provided.")
        {

        }

        public InvalidLoginException(string message) : base(message)
        {

        }

        public InvalidLoginException(string message, Exception inner) : base(message, inner)
        {

        }

    }
}
