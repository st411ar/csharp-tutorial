namespace CSharp6Tutorial
{
    public class SampleEntity
    {
        public double x { get; }
        public double y { get; }
        public double z { get; }

        public SampleEntity(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString() => $"({x}; {y}; {z})";
    }
}