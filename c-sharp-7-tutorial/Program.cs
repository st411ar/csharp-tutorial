using System;
using System.Collections.Generic;

namespace CSharp7Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // OutVariableDeclaration();
            // Tuples();
            // TypePatternWithIsExpression();
            TypePatternWithSwitchStatement();
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

        static void TypePatternWithIsExpression()
        {
            object count = "5";
            if (count is int number)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine($"{count} is not an integer");
            }
        }

        static void TypePatternWithSwitchStatement()
        {
            test(5);

            long longValue = 12;
            test(longValue);

            int? answer = 42;
            test(answer);

            double pi = 3.14;
            test(pi);

            string sum = "12";
            test(sum);

            answer = null;
            test(answer);

            string message = "This is a longer message";
            test(message);

            void test(object obj)
            {
                switch (obj)
                {
                    case 5:
                        Console.WriteLine("The object is 5");
                        break;
                    case int i:
                        Console.WriteLine($"The object is an integer: {i}");
                        break;
                    case long l:
                        Console.WriteLine($"The object is a long: {l}");
                        break;
                    case double d:
                        Console.WriteLine($"The object is a double: {d}");
                        break;
                    case string s when s.StartsWith("This"):
                        Console.WriteLine($"This was a string that started with the word 'This': {s}");
                        break;
                    case string s:
                        Console.WriteLine($"The object is a string: {s}");
                        break;
                    case null:
                        Console.WriteLine($"The object is null");
                        break;
                    default:
                        Console.WriteLine($"The object is some other type");
                        break;
                }
            }
        }
    }
}
