namespace _8_1_ExceptionHandlingIntro
{
    internal class AuthenticationService
    {
        public void Login(string username, string password)
        {
            if (username == "admin" && password == "password123")
            {
                throw new InvalidLoginException("The user name or password is incorrect.");
            }

            Console.WriteLine("Login succesfull.");
        }
    }
}
