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

            if (int.TryParse(input, out int result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Could not parse input");
            }
            Console.WriteLine(result);

            if (int.TryParse(input, out var answer))
            {
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine("Could not parse input");
            }
        }
    }
}
