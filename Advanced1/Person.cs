namespace Advanced1
{
    internal class Person
    {
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public Person(double height)
        {
            Height = height;
        }

        internal string Name;
        internal int Age;
        internal double Height;
    }
}