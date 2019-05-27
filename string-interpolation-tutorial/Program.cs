using System;
using System.Collections.Generic;

namespace StringInterpolationTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Vitaly";
            Console.WriteLine($"Hello, {name}. It's a pleasure to meet you!");

            var item = (Name: "eggplant", Price: 1.99m, perPackage: 3);
            var date = DateTime.Now;
            Console.WriteLine($"On {date:d}, the price of {item.Name} was {item.Price:c2} per {item.perPackage} items.");

            var inventory = new Dictionary<string, int>()
            {
                ["hammer, ball pein"] = 18,
                ["hammer, cross pein"] = 5,
                ["screwdriver, Phillips #2"] = 14
            };
            Console.WriteLine($"Inventory on {DateTime.Now:d}");
            Console.WriteLine(" ");
            Console.WriteLine($"|{"Item",-25}|{"Quantity",10}|");
            foreach (var unit in inventory)
            {
                Console.WriteLine($"|{unit.Key,-25}|{unit.Value,10}|");
            }
        }
    }
}
