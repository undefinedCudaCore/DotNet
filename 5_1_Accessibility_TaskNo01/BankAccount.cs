namespace _5_1_Accessibility_TaskNo01
{
    internal class BankAccount
    {
        public BankAccount()
        {

        }
        protected double _balance;
        public double MyProperty
        {
            get { return _balance; }
            set { _balance = value; }
        }


        private double GetTotalBalance()
        {
            return Math.Round(_balance, 2);
        }

        public double SetBalance(double balance)
        {
            return _balance += balance;
        }

        protected void PrintBalance()
        {
            Console.WriteLine($"Your balance is: {GetTotalBalance()}.");
        }
    }
}
