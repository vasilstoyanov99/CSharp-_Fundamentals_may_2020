using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, City> citiesData = new Dictionary<string, City>();

            while (input != "Sail")
            {
                string[] data = input.Split("||", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string city = data[0];
                int population = int.Parse(data[1]);
                int gold = int.Parse(data[2]);

                if (!citiesData.ContainsKey(city))
                {
                    City newCity = new City(population, gold, city);
                    citiesData.Add(city, newCity);
                }
                else
                {
                    citiesData[city].Gold += gold;
                    citiesData[city].Population += population;
                }

                input = Console.ReadLine();
            }

            string secondInput = Console.ReadLine();

            while (secondInput != "End")
            {
                string[] data = secondInput.Split("=>", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (data[0] == "Plunder")
                {
                    PlunderTheCity(data, citiesData);
                }
                else if (data[0] == "Prosper")
                {
                    ProsperTheCity(data, citiesData);
                }
                secondInput = Console.ReadLine();
            }

            if (citiesData.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {citiesData.Count} wealthy settlements to go to:");

                foreach (var pair in citiesData.Values.OrderByDescending(x => x.Gold).ThenBy(x => x.Name))
                {
                    Console.WriteLine($"{pair.Name} -> Population: {pair.Population} citizens, Gold: {pair.Gold} kg");
                }
            }
        }

        static void PlunderTheCity(string[] data, Dictionary<string, City> citiesData)
        {
            string city = data[1];
            int killedPeople = int.Parse(data[2]);
            int stolenGold = int.Parse(data[3]);

            if (citiesData[city].Population > 0 && citiesData[city].Gold > 0)
            {
                citiesData[city].Population -= killedPeople;
                citiesData[city].Gold -= stolenGold;
                Console.WriteLine($"{city} plundered! {stolenGold} gold stolen, {killedPeople} citizens killed.");

                if (citiesData[city].Population <= 0 || citiesData[city].Gold <= 0)
                {
                    citiesData.Remove(city);
                    Console.WriteLine($"{city} has been wiped off the map!");
                }
            }
        }

        static void ProsperTheCity(string[] data, Dictionary<string, City> citiesData)
        {
            string city = data[1];
            int GoldToAdd = int.Parse(data[2]);

            if (GoldToAdd >= 0) 
            {
                citiesData[city].Gold += GoldToAdd;
                Console.WriteLine($"{GoldToAdd} gold added to the city treasury. {city} now has {citiesData[city].Gold} gold.");
            }
            else if (GoldToAdd < 0)
            {
                Console.WriteLine("Gold added cannot be a negative number!");
            }
        }
    }

    class City
    {
        public int Population { get; set; }
        public int Gold { get; set; }
        public string Name { get; set; }
        public City(int population, int gold, string name)
        {
            this.Population = population;
            this.Gold = gold; 
            this.Name = name;
        }
    }
}
