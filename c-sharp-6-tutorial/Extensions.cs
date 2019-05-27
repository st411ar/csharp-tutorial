namespace CSharp6Tutorial
{
    public static class Extensions
    {
        public static void Add(this Path path, double x, double y, double z) => path.Add(new SampleEntity(x, y, z));
    }
}