namespace _3_2_Virtual_Methods.MyEmployee

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
