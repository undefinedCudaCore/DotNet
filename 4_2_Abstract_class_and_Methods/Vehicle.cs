
namespace _4_2_Abstract_class_and_Methods
{
    internal abstract class Vehicle
    {
        protected Vehicle(int tireCount, int tireWidth, int tireHeight, int tireRadius, int windowCount, bool widowTint, bool skyRoof, string tireModel, string bodyFrame, string fuel)
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
        }

        public int TireCount { get; set; }
        public int TireWidth { get; set; }
        public int TireHeight { get; set; }
        public int TireRadius { get; set; }
        public int WindowCount { get; set; }
        public bool WidowTint { get; set; }
        public bool SkyRoof { get; set; }
        public string TireModel { get; set; }
        public string BodyFrame { get; set; }
        public string Fuel { get; set; }
    }
}
