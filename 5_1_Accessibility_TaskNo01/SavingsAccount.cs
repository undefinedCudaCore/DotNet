namespace _5_1_Accessibility_TaskNo01
{
    internal class SavingsAccount : BankAccount
    {
        public SavingsAccount() : base()
        {
            _interestRate = 0.1;
        }

        private double _interestRate;

        public void UsePrinMethod()
        {
            PrintBalance();
        }

        public double CalculateInterest(int inversYearValue)
        {
            double caltulateInterest = _balance * Math.Pow((1 + _interestRate), inversYearValue) - _balance;


            return _balance = caltulateInterest;
        }
    }
}
