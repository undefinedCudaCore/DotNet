namespace _5_1_Accessibility_TaskNo01
{
    internal class CheckingAccount : BankAccount
    {
        public CheckingAccount(Print bankAccount)
        {
            //double prop = bankAccount.MyProperty;
            //Console.WriteLine(prop);
            //bankAccount.MyProperty += 12;
            //Console.WriteLine(bankAccount.MyProperty);
        }

        protected double _overdraftLimit = 20;

        public double Withdraw(double ammountToWithdraw, Print bankAccount)
        {
            return bankAccount.MyProperty -= ammountToWithdraw;
        }
    }
}
