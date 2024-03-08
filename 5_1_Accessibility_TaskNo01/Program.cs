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
            bankAccount.SetBalance(5.25);

            bankAccount.UsePrinMethod();

        }
    }
}
