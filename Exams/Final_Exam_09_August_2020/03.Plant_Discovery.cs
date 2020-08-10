using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = a > b ? a : b;
            Console.WriteLine(c);


            int linesOfInput = int.Parse(Console.ReadLine());
            Dictionary<string, Plant> allPlants = new Dictionary<string, Plant>();

            for (int i = 0; i < linesOfInput; i++)
            {
                string[] data = Console.ReadLine().Split("<->").ToArray();
                string plant = data[0];
                double rarity = double.Parse(data[1]);

                if (allPlants.ContainsKey(plant))
                {
                    allPlants[plant].Rarity = rarity;
                }
                else
                {
                    Plant newPlant = new Plant(rarity);
                    allPlants.Add(plant, newPlant);
                }

            }

            string input = Console.ReadLine();

            while (input != "Exhibition")
            {
                string[] commands = input.Split(new char[] { ':', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (commands[0])
                {
                    case "Rate":
                        AddNewRating(allPlants, commands);
                        break;
                    case "Update":
                        UpdatePlantRarity(allPlants, commands);
                        break;
                    case "Reset":
                        RemoveAllRatings(allPlants, commands[1]);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (var item in allPlants)
            {
                string plant = item.Key;
                allPlants[plant].GetAverageRating();
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var plant in allPlants.OrderByDescending(x => x.Value.Rarity).ThenByDescending(x => x.Value.averageRating))
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {plant.Value.averageRating:f2}");
            }

        }

        static void AddNewRating(Dictionary<string, Plant> allPlants, string[] commands)
        {
            string plant = commands[1];

            if (!allPlants.ContainsKey(plant))
            {
                Console.WriteLine("error");
                return;
            }

            int rating = int.Parse(commands[2]);
            allPlants[plant].allRatings.Add(rating);
        }

        static void UpdatePlantRarity(Dictionary<string, Plant> allPlants, string[] commands)
        {
            string plant = commands[1];

            if (!allPlants.ContainsKey(plant))
            {
                Console.WriteLine("error");
                return;
            }

            double newRarity = double.Parse(commands[2]);
            allPlants[plant].Rarity = newRarity;
        }

        static void RemoveAllRatings(Dictionary<string, Plant> allPlants, string plant)
        {
            if (!allPlants.ContainsKey(plant))
            {
                Console.WriteLine("error");
                return;
            }

            allPlants[plant].allRatings.Clear();
        }
    }

    class Plant
    {
        public double Rarity { get; set; }
        public List<int> allRatings = new List<int>();
        public double averageRating = 0.00;

        public Plant(double rarity)
        {
            this.Rarity = rarity;
        }

        public void GetAverageRating()
        {
            if (allRatings.Count == 0)
            {
                averageRating = 0.00;
            }
            else
            {
                int ratingsSum = allRatings.Sum();
                averageRating = ratingsSum * 1.0 / allRatings.Count * 1.0;
            }
        }
    }
}
