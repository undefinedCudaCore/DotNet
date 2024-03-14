namespace _7_2_Generic_Exercises
{
    internal class ObjectForList
    {
        public ObjectForList(int age, int salary, string name, string surename, string greeting)
        {
            Age = age;
            Name = name;
            Surename = surename;
            Greeting = greeting;
            Salary = salary;
        }

        public int Age { get; set; }
        public int Salary { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public string Greeting { get; set; }

        public override string ToString()
        {
            return Age.ToString() + " " + Salary.ToString() + " " + Name + " " + Surename + " " + Greeting;
        }
    }
}
