namespace Advanced1
{
    internal class Hamster
    {
        public Hamster()
        {

        }
        public Hamster(PetName name, PetWeight weight, PetColor color)
        {
            HamsterName = name;
            Weight = weight;
            Color = color;
        }

        internal PetName HamsterName { get; set; }
        internal PetWeight Weight { get; set; }
        internal PetColor Color { get; set; }
    }
}
