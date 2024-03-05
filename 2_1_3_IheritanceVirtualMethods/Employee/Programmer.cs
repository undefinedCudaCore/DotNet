namespace _2_1_3_IheritanceVirtualMethods.Employee
{
    internal class Programmer : Employee
    {
        public Programmer(string lenguage, string name, int salary) : base(name, salary)
        {
            ProgrammingLanguage = lenguage;
        }
        public string ProgrammingLanguage { get; set; }
    }
}
