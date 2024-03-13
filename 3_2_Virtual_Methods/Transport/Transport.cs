namespace _3_2_Virtual_Methods.Transport
{
    internal class Transport
    {
        public Transport(double speed)
        {
            Speed = speed;
        }

        public double Speed { get; set; }

        public virtual double MeasureSpeed()
        {
            return Speed;
        }
    }
}
