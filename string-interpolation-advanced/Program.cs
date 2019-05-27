﻿using System;

namespace StringInterpolationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 3;
            double b = 4;
            Console.WriteLine($"Area of the right triangle with legs of {a} and {b} is {0.5 * a * b}");
            Console.WriteLine($"Length of the hypotenuse of the right triangle with legs of {a} and {b} is {CalculateTypotenuse(a, b)}");

            double CalculateTypotenuse(double leg1, double leg2) => Math.Sqrt(leg1 * leg1 + leg2 * leg2);


            var date = new DateTime(1731, 11, 25);
            Console.WriteLine($"On {date:dddd, MMMM dd, yyyy} Leonhard Euler introduced the letter e to denote {Math.E:f5} in a letter to Christian Goldbach.");


            const int NameAlignment = -9;
            const int ValueAlignment = 7;

            a = 3;
            b = 4;
            Console.WriteLine($"Three classical Pythagorean means of {a} and {b}:");
            Console.WriteLine($"|{"Arithmetic",NameAlignment}|{0.5 * (a + b),ValueAlignment:f3}|");
            Console.WriteLine($"|{"Geometric",NameAlignment}|{Math.Sqrt(a * b),ValueAlignment:f3}|");
            Console.WriteLine($"|{"Harmonic",NameAlignment}|{2 / (1/a + 1/b),ValueAlignment:f3}|");
        }
    }
}
