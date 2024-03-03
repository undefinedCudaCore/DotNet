namespace Advanced1
{
    internal class Dog
    {
        public Dog()
        {

        }
        public Dog(PetName name, PetWeight weight, PetColor color)
        {
            DogName = name;
            Weight = weight;
            Color = color;
        }

        internal PetName DogName { get; set; }
        internal PetWeight Weight { get; set; }
        internal PetColor Color { get; set; }
    }
}
