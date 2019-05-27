using System;
using System.Collections.Generic;
using System.Linq;

using static System.Console;

namespace CSharp6Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkingWithStrings();
            WorkingWithNull();
            WorkingWithExceptionFilter();
            WorkingWithNameOf();
            WorkingWithObjectInitialization();
        }

        static void WorkingWithStrings()
        {
            var p = new Person("Bill", "Wagner");
            WriteLine($"The name, in all caps: {p.AllCaps()}");
            WriteLine($"The name: {p}");

            var phrase = "the quick brown fox jumps over the lazy dog";
            var wordLength = from word in phrase.Split(" ") select word.Length;
            WriteLine($"The average word length is: {wordLength.Average():F2}");
        }

        static void WorkingWithNull()
        {
            string s = null;
            WriteLine(s?.Length);

            char? c = s?[0];
            WriteLine(c.HasValue);

            bool hasMore = s?.ToCharArray()?.GetEnumerator()?.MoveNext() ?? false;
            WriteLine(hasMore);
        }

        static void WorkingWithExceptionFilter()
        {
            try
            {
                string s = null;
                WriteLine(s.Length);
            } catch (Exception e) when (LogException(e))
            {
            }

            WriteLine("Exception must have been handled");
        }

        static void WorkingWithNameOf()
        {
            WriteLine(nameof(System.String));

            int j = 5;
            WriteLine(nameof(j));

            List<string> names = new List<string>();
            WriteLine(nameof(names));
        }

        static void WorkingWithObjectInitialization()
        {
            var messages = new Dictionary<int, string>
            {
                [404] = "Page not found",
                [302] = "Page moved, but left a forwarding address.",
                [500] = "The web server can't come out to play today."
            };

            WriteLine(messages[302]);


            Path path = new Path
            {
                new SampleEntity(0.1, 0.2, 0.3),
                new SampleEntity(0.4, 0.5, 0.6)
            };
            WriteLine(path.Count());
            WriteLine(path);

            SampleEntity sampleEntity = new SampleEntity(1.1, 1.2, 1.3);
            path.Add(sampleEntity);
            WriteLine(path.Count());
            WriteLine(path);

            path.Add(1.4, 1.5, 1.6);
            WriteLine(path.Count());
            WriteLine(path);
        }

        private static bool LogException(Exception e)
        {
            WriteLine($"\tIn the log routine. Caught {e.GetType()}");
            WriteLine($"\tMessage: {e.Message}");
            return true;
        }
    }
}
