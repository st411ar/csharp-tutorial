namespace CSharp6Tutorial
{
    public class Person
    {
        public string FirstName { get; }
        public string MiddleName { get; } = "";
        public string LastName { get; }

        public Person(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        public Person(string first, string middle, string last)
        {
            FirstName = first;
            MiddleName = middle;
            LastName = last;
        }

        public override string ToString() => $"{FirstName} {LastName}";

        public string AllCaps() => ToString().ToUpper();
    }
}