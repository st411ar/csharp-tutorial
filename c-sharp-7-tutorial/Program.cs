using System;

namespace CSharp7Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            OutVariableDeclaration();
        }

        static void OutVariableDeclaration()
        {
            var input = "1234";
            int numericResult;
            if (int.TryParse(input, out numericResult))
            {
                Console.WriteLine(numericResult);
            }
            else
            {
                Console.WriteLine("Could not parse input");
            }
        }
    }
}
