namespace TaskNo03_Additional
{
    internal class AngryClient : Customer
    {
        public AngryClient(bool cash, bool creditCard, string type, string name, string sureName, string position, string gender, string hairStyle, int age) : base(type, name, sureName, hairStyle, age)
        {
            Name = name;
            SureName = sureName;
            Position = position;
            Gender = gender;
            Type = type;
            HairStyle = hairStyle;
            Age = age;
            Cash = cash;
            CreditCard = creditCard;
        }

        public override void WhatDoesTheFoxSay()
        {
            Console.WriteLine("Give me my money back!!!");
        }
    }
}