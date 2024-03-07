namespace TaskNo03_Additional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee donald = new Employee("Human", "Donald", "Trump", "Male", "Good POSITION", "Blond", 68);

            Customer emily = new Customer("Human", "Emily", "Blunt", "Blond", 20);
            emily.Gender = "Female";
            emily.Cash = true;
            emily.CreditCard = true;

            AngryClient bob = new AngryClient(true, false, "Alien", "Robert", "Strachovsky", "Disrespectful and condescending", "Male", "bold", 45);
            SatisfiedCustomer lucy = new SatisfiedCustomer(false, true, "Human", "Lucy", "Sparcles", "Friendly", "Female", "Upsweep", 25);

            Manager stenley = new Manager("Humannoid", 1500, 48, 7, "Stenley", "Makentosh", "Senion manager", "Male", "Spike", 38);
            Programmer will = new Programmer("Android", 3000, 60, 5, "Will", "Smith", "Mid level programmer", "Male", "Shag", 34);

            List<Person> personList = new List<Person>();
            personList.Add(donald);
            personList.Add(emily);
            personList.Add(bob);
            personList.Add(lucy);
            personList.Add(stenley);
            personList.Add(will);

            foreach (Person person in personList)
            {
                person.WhatDoesTheFoxSay();
            }
        }
    }
}
