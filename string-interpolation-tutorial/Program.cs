using System;
using System.Collections.Generic;

namespace StringInterpolationTutorial
{
    class Program
    {
        public enum Unit { item, kilogram, gram, dozen };


        static void Main(string[] args)
        {
            Intro();

            FormatDifferentDataTypes();
            FieldWidthAndAlignment();
            Combine();

            FormatDifferentDataTypesForLocalEnv();
            FieldWidthAndAlignmentForLocalEnv();
        }


        static void Intro()
        {
            var name = "Vitaly";
            Console.WriteLine($"Hello, {name}. It's a pleasure to meet you!");
        }

        static void FormatDifferentDataTypes()
        {
            var item = (Name: "eggplant", Price: 1.99m, perPackage: 3);
            var date = DateTime.Now;
            Console.WriteLine($"On {date:d}, the price of {item.Name} was {item.Price:c2} per {item.perPackage} items.");
        }

        static void FieldWidthAndAlignment()
        {
            var inventory = new Dictionary<string, int>()
            {
                ["hammer, ball pein"] = 18,
                ["hammer, cross pein"] = 5,
                ["screwdriver, Phillips #2"] = 14
            };
            Console.WriteLine($"Inventory on {DateTime.Now:d}");
            Console.WriteLine(" ");
            Console.WriteLine($"|{"Item",-25}|{"Quantity",10}|");
            foreach (var item in inventory)
            {
                Console.WriteLine($"|{item.Key,-25}|{item.Value,10}|");
            }
        }

        static void Combine()
        {
            Console.WriteLine($"[{DateTime.Now,-20:d}] Hour [{DateTime.Now,-10:HH}] [{1063.342,15:N2}] feet");
        }

        static void FormatDifferentDataTypesForLocalEnv()
        {
            var item = new Vegetable("eggplant");
            var date = DateTime.Now;
            var price = 1.99m;
            var unit = Unit.item;
            Console.WriteLine($"On {date:d}, the price of {item} was {price:c2} per {unit}.");
        }

        static void FieldWidthAndAlignmentForLocalEnv()
        {
            var titles = new Dictionary<string, string>()
            {
                ["Doyle, Arthur Conan"] = "Hound of the Baskervilles, The",
                ["London, Jack"] = "Call of the Wild, The",
                ["Shakespeare, William"] = "Tempest, The"
            };
            Console.WriteLine("Author and Title List");
            Console.WriteLine();
            Console.WriteLine($"|{"Author",-25}|{"Title",30}|");
            foreach (var title in titles) {
                Console.WriteLine($"|{title.Key,-25}|{title.Value,30}|");
            }
        }
    }
}
