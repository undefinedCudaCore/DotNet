namespace _3_2_Virtual_Methods.MyEmployee

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

        public virtual void Greeting()
        {
            Console.WriteLine("Hello!");
        }
    }
}
