
using System.Text.RegularExpressions;

namespace ClassMethods
{
    internal class Human
    {
        public Human(string name, string surename, string email, int age)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Surename = surename ?? throw new ArgumentNullException(nameof(surename));
            Email = email ?? throw new ArgumentNullException(nameof(surename));
            Age = age;
        }

        internal string Name { get; set; }
        internal string Surename { get; set; }
        internal string Email { get; set; }
        internal int Age { get; set; }

        public void UpdateEmail(string newEmail)
        {
            if (IsValidEmail(newEmail))
            {
                Email = newEmail;
            }
            else
            {
                Console.WriteLine("Not valid email.");
            }
        }

        private bool IsValidEmail(string newEmail)
        {
            string regexPattern = @"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)*(\.[a-zA-Z]{2,})$";
            return Regex.IsMatch(newEmail, regexPattern);
        }

        public string PrintInfo()
        {
            return $"{Name} {Email} {Surename} {Age}";
        }
    }
}
