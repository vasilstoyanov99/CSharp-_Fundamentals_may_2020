using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Dictionary<string, Car> allCars = new Dictionary<string, Car>(); 

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] data = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = data[0];
                int mileage = int.Parse(data[1]);
                int fuel = int.Parse(data[2]);
                Car newCar = new Car(model, mileage, fuel);
                allCars.Add(model, newCar);
            }

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] commands = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (commands[0])
                {
                    case "Drive":
                        Drive(allCars, commands);
                        break;
                    case "Refuel":
                        Refuel(allCars, commands);
                        break;
                    case "Revert":
                        Revert(allCars, commands);
                        break;
                }

                input = Console.ReadLine();
            }

            if (allCars.Count > 0)
            {
                foreach (var car in allCars.Values.OrderByDescending(x => x.Mileage).ThenBy(x => x.Model))
                {
                    Console.WriteLine($"{car.Model} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
                }
            }
        }

        static void Drive(Dictionary<string, Car> allCars, string[] commands)
        {
            string model = commands[1];
            int distance = int.Parse(commands[2]);
            int neededFuel = int.Parse(commands[3]);

            if (allCars[model].Fuel >= neededFuel)
            {
                allCars[model].Mileage += distance;
                allCars[model].Fuel -= neededFuel;
                Console.WriteLine($"{model} driven for {distance} kilometers. {neededFuel} liters of fuel consumed.");

                if (allCars[model].Mileage >= 100000)
                {
                    allCars.Remove(model);
                    Console.WriteLine($"Time to sell the {model}!");
                }
            }
            else
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
        }

        static void Refuel(Dictionary<string, Car> allCars, string[] commands)
        {
            string model = commands[1];
            int toRefill = int.Parse(commands[2]);

            bool isReachedMaxCapacity = allCars[model].Fuel + toRefill > 75;

            if (isReachedMaxCapacity)
            {
                int temp = allCars[model].Fuel;
                allCars[model].Fuel = 75;
                Console.WriteLine($"{model} refueled with {75 - temp} liters");
            }
            else
            {
                allCars[model].Fuel += toRefill;
                Console.WriteLine($"{model} refueled with {toRefill} liters");
            }
        }

        static void Revert(Dictionary<string, Car> allCars, string[] commands)
        {
            string model = commands[1];
            int KMtoDecrease = int.Parse(commands[2]);
            allCars[model].Mileage -= KMtoDecrease;

            if (allCars[model].Mileage < 10000)
            {
                allCars[model].Mileage = 10000;
            }
            else
            {
                Console.WriteLine($"{model} mileage decreased by {KMtoDecrease} kilometers");
            }
        }
    }

    class Car
    {
        public string Model { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }

        public Car(string model, int mileage, int fuel)
        {
            this.Model = model;
            this.Mileage = mileage;
            this.Fuel = fuel;
        }
    }
}
