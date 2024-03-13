namespace _4_2_Abstract_class_and_Methods
{
    internal class Motorcicle : Vehicle
    {
        public Motorcicle(bool swamper, int tireCount, int tireWidth, int tireHeight, int tireRadius, int windowCount, bool widowTint, bool skyRoof, string tireModel, string bodyFrame, string fuel) : base(tireCount, tireWidth, tireHeight, tireRadius, windowCount, widowTint, skyRoof, tireModel, bodyFrame, fuel)
        {
            TireCount = tireCount;
            TireWidth = tireWidth;
            TireHeight = tireHeight;
            TireRadius = tireRadius;
            WindowCount = windowCount;
            WidowTint = widowTint;
            SkyRoof = skyRoof;
            TireModel = tireModel ?? throw new ArgumentNullException(nameof(tireModel));
            BodyFrame = bodyFrame ?? throw new ArgumentNullException(nameof(bodyFrame));
            Fuel = fuel ?? throw new ArgumentNullException(nameof(fuel));
            Swamper = swamper;
        }

        public bool Swamper { get; set; }
    }
}
