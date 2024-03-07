namespace TaskNo03_Additional
{
    internal class Customer : Person
    {

        public Customer(string type, string name, string sureName, string hairStyle, int age) : base(type, name, sureName, hairStyle, age)
        {
            Name = name;
            SureName = sureName;
            Type = type;
            HairStyle = hairStyle;
            Age = age;
        }

        public bool Cash { get; set; }
        public bool CreditCard { get; set; }
        public bool GPay { get; set; }
        public bool ApplePay { get; set; }

        public override void WhatDoesTheFoxSay()
        {
            Console.WriteLine("Hello, can i get a coffee please.");
        }
    }
}
