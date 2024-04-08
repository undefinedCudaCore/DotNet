namespace _7_2_Generic_Exercises
{
    internal class FourSideGeometricFigure
    {
        public FourSideGeometricFigure(string name, int basee, int height)
        {
            Name = name;
            Base = basee;
            Height = height;
        }

        public string Name { get; set; }
        public int Base { get; set; }
        public int Height { get; set; }

        public int GetArea()
        {
            return Base * Height;
        }
        public override string ToString()
        {
            return Name + " " + "Area" + " " + GetArea();
        }
    }
}