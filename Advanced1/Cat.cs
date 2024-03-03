namespace Advanced1
{
    internal class Cat
    {
        public Cat()
        {

        }
        public Cat(PetName name, PetWeight weight, PetColor color)
        {
            CatName = name;
            Weight = weight;
            Color = color;
        }

        internal PetName CatName { get; set; }
        internal PetWeight Weight { get; set; }
        internal PetColor Color { get; set; }
    }
}
