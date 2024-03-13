namespace _5_1_Accessibility_TaskNo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1 -------------------------------
            Student student = new Student("Alice", 19);
            Student student2 = new Student("Alice", 19);
            Student student3 = new Student("Alice", 19);

            student.GetStudentId();
            student2.GetStudentId();
            student3.GetStudentId();

            //Exercise 2 -------------------------------
            Teacher teacher = new Teacher("John", 66);

            //Console.WriteLine(teacher.GetSubject());

            //Exercise 3 -------------------------------
            Print bankAccount = new Print();
            bankAccount.SetBalance(5.25);
            bankAccount.SetBalance(5.25);
            bankAccount.SetBalance(5.25);
            bankAccount.SetBalance(5.25);
            bankAccount.SetBalance(505.25);

            bankAccount.UsePrinMethod();

            //Exercise 4 -------------------------------
            SavingsAccount savings = new SavingsAccount();

            savings.SetBalance(100);
            savings.CalculateInterest(10);

            //savings.UsePrinMethod();

            //Exercise 5 -------------------------------
            CheckingAccount check = new CheckingAccount(bankAccount);
            check.Withdraw(100, bankAccount);
            Console.Write("Balance after withdraw:");
            bankAccount.UsePrinMethod();
        }
    }
}
