namespace ClassMethodsExercices
{
    internal class Rectangle
    {
        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int Height { get; set; }
        public int Width { get; set; }

        public int Area()
        {
            return Height * Width;
        }
        public int Perimeter()
        {
            return 2 * (Height + Width);
        }
    }
}
