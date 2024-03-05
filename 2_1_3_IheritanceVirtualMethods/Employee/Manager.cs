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
            foreach (var employee in EmployeeList)
            {
                if (employee is Programmer)
                {
                    Programmer emp = employee as Programmer;

                    Console.Write(emp.Name + "\t");
                    Console.Write(emp.Salary + "\t");
                    Console.Write(emp.ProgrammingLanguage + "\n");
                }
            }
            Console.WriteLine(EmployeeList.Count);
        }
    }
}
