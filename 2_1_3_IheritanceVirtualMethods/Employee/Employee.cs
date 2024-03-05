namespace _2_1_3_IheritanceVirtualMethods.Employee
{
    internal class Employee
    {
        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
