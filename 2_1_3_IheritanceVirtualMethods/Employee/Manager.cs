namespace _2_1_3_IheritanceVirtualMethods.Employee
{
    internal class Manager : Employee
    {
        public Manager(string name, int salary) : base(name, salary)
        {
            Name = name;
            Salary = salary;
            EmployeeList = new List<Employee>();

        }

        public int Employees { get; set; }
        public List<Employee> EmployeeList { get; set; }

        public List<Employee> AddProgrammer(Employee programmer)
        {
            EmployeeList.Add(programmer);
            return EmployeeList;
        }

        public void PrintProgrammersInformationOfOneManager()
        {
            for (int i = 0; i < EmployeeList.Count; i++)
            {
                if (EmployeeList[i] is Programmer)
                {

                    Console.Write(EmployeeList[i].Name + "\t");
                    Console.Write(EmployeeList[i].Salary + "\t");
                    //Console.Write(EmployeeList[i].ProgrammingLanguage + "\n");
                }
            }
            Console.WriteLine(EmployeeList.Count);
        }
    }
}
