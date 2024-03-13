namespace OOP_Task_04.Person
{
    internal class Person1
    {
        public Person1()
        {
            MyAddress = new Address();
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public Address MyAddress { get; set; }
    }
}
