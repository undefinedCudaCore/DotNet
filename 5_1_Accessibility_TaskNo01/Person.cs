namespace _5_1_Accessibility_TaskNo01
{
    internal class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        protected string Name { get; set; }
        protected int Age { get; set; }
    }
}
