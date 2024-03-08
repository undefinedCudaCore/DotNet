namespace _5_1_Accessibility_TaskNo01
{
    internal class BankAccount
    {
        public BankAccount()
        {

        }
        private double _balance;

        internal double GetTotalBalance()
        {
            return _balance;
        }

        internal double SetBalance(double balance)
        {
            return _balance += balance;
        }

        protected void PrintBalance()
        {
            Console.WriteLine($"Your balance is: {GetTotalBalance()}.");
        }
    }
}
