namespace _7_3_Generics_and_propfull.ModelsPropfull
{
    internal class Person
    {
        private readonly string _name;

        public Person(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
