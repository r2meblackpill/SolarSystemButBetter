using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SolarSystemButBetter
{
    class Program
    {
        public class Item
        {
            string name;
            int mass;

            public Item(string _name, int _mass)
            {
                name = _name;
                mass = _mass;
            }

            public string Name { get { return name; } }
            public int Mass { get { return mass; } }
        }
        static void Main(string[] args)
        {
            PlanetFunction();
        }

        public static void PlanetFunction()
        {
            string filePath = @"C:\Users\opilane\samples";
            string innerPlanets = @"innerPlanets.txt";
            string outerPlanets = @"outerPlanets.txt";

            List<Item> innerItems = new List<Item>();
            List<Item> outerItems = new List<Item>();

            List<string> linesFromInner = File.ReadAllLines(Path.Combine(filePath, innerPlanets)).ToList();
            List<string> linesFromOuter = File.ReadAllLines(Path.Combine(filePath, outerPlanets)).ToList();

            foreach (string line in linesFromInner)
            {
                string[] innerArray = line.Split(new char[] { '$' }, StringSplitOptions.RemoveEmptyEntries);
                Item newItem = new Item(innerArray[0], Int32.Parse(innerArray[1]));
                innerItems.Add(newItem);
            }

            foreach (string line in linesFromOuter)
            {
                string[] outerArray = line.Split(new char[] { '$' }, StringSplitOptions.RemoveEmptyEntries);
                Item newItem = new Item(outerArray[0], Int32.Parse(outerArray[1]));
                outerItems.Add(newItem);
            }

            int innerTotal = 0;
            foreach (Item item in innerItems)
            {
                Console.WriteLine($"INNER Planet: {item.Name} | Mass: {item.Mass}");
                innerTotal += item.Mass;
            }

            int outerTotal = 0;
            foreach (Item item in outerItems)
            {
                Console.WriteLine($"OUTER Planet: {item.Name} | Mass: {item.Mass}");
                outerTotal += item.Mass;
            }

            int finalTotal = innerTotal + outerTotal;
            Console.WriteLine("Inner planets mass: " + innerTotal);
            Console.WriteLine("Outer planets mass: " + outerTotal);
            Console.WriteLine("Total planet mass: " + finalTotal);
        }
    }
}
