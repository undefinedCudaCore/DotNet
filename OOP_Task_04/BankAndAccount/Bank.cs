namespace OOP_Task_04.BankAndAccount
{
    internal class Bank
    {
        public Bank()
        {
            Accounts = new List<Account>();
        }

        public List<Account> Accounts { get; set; }
    }
}
