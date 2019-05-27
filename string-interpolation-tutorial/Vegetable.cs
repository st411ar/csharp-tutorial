namespace StringInterpolationTutorial
{
    public class Vegetable
    {
        public string Name { get; }

        public Vegetable(string name) => Name = name;

        public override string ToString() => Name;
    }
}