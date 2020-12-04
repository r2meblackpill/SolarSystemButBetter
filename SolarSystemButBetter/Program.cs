using System;
using System.Collections.Generic;
using System.IO;

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
            WriteOuterPlanets();
            WriteInnerPlanets();
        }

        public static void WriteOuterPlanets()
        {
            Console.WriteLine("OUTER PLANETS");
            List<string> planetsList = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter planet:");
                string item = Console.ReadLine();
                Console.WriteLine("Enter planet mass:");
                string mass = Console.ReadLine();

                string line = $"{item}${mass}";
                planetsList.Add(line); //add a line to the shoppingList list
            }

            string filePath = @"C:\Users\opilane\samples";
            string fileName = @"outerPlanets.txt";
            File.WriteAllLines(Path.Combine(filePath, fileName), planetsList);


        }
        public static void WriteInnerPlanets()
        {
            Console.WriteLine("INNER PLANETS");
            List<string> planetsList = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter planet:");
                string item = Console.ReadLine();
                Console.WriteLine("Enter planet mass:");
                string mass = Console.ReadLine();

                string line = $"{item}${mass}";
                planetsList.Add(line); //add a line to the shoppingList list
            }

            string filePath = @"C:\Users\opilane\samples";
            string fileName = @"innerPlanets.txt";
            File.WriteAllLines(Path.Combine(filePath, fileName), planetsList);
        }
    }
}
