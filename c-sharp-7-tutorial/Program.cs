using System;
using System.Collections.Generic;

namespace CSharp7Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            OutVariableDeclaration();
            Tuples();
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

        static void Tuples()
        {
            (string Alpha, string Beta) namedLetters = ( "a", "b" );
            Console.WriteLine($"{namedLetters.Alpha}, {namedLetters.Beta}");

            var alphabetStart = ( Alpha: "a", Beta: "b" );
            Console.WriteLine($"{alphabetStart.Alpha}, {alphabetStart.Beta}");

            (int Max, int Min) Range(IEnumerable<int> sequence)
            {
                int Min = int.MaxValue;
                int Max = int.MinValue;
                foreach (var n in sequence)
                {
                    Min = (n < Min) ? n : Min;
                    Max = (n > Max) ? n : Max;
                }
                return (Max, Min);
            }

            var numbers = new int[] { 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            var range = Range(numbers);
            Console.WriteLine(range);

            (int max, int min) = Range(numbers);
            Console.WriteLine(max);
            Console.WriteLine(min);

            (int maxValue, _) = Range(numbers);
            Console.WriteLine(max);
        }
    }
}
