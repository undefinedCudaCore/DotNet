namespace OOP_Task_04.BankAndAccount
{
    internal class Account
    {
        public Account()
        {
            AccountHolder = "";
            Balance = double.NaN;
        }

        public string AccountHolder { get; set; }
        public double Balance { get; set; }

    }
}
