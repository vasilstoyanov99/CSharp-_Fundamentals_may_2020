using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _06.Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Car> allCars = new List<Car>();
            List<Truck> allTrucks = new List<Truck>();

            while (input != "End")
            {
                string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (data[0] == "car")
                {
                    Car newCar = new Car(data[1], data[2], double.Parse(data[3]));
                    allCars.Add(newCar);
                }
                else
                {
                    Truck newTruck = new Truck(data[1], data[2], double.Parse(data[3]));
                    allTrucks.Add(newTruck);
                }

                input = Console.ReadLine();
            }

            string secondInput = Console.ReadLine();

            while (secondInput != "Close the Catalogue")
            {
                string modelToPrint = secondInput;
                foreach (var vehicle in allCars.Where(x => x.Model == modelToPrint))
                {
                    Console.WriteLine($"Type: {vehicle.Type}" + "\n" + $"Model: {vehicle.Model}" + "\n"
                        + $"Color: {vehicle.Color}" + "\n" + $"Horsepower: {vehicle.Horsepower}");
                }

                foreach (var vehicle in allTrucks.Where(x => x.Model == modelToPrint))
                {
                    Console.WriteLine($"Type: {vehicle.Type}" + "\n" + $"Model: {vehicle.Model}" + "\n"
                        + $"Color: {vehicle.Color}" + "\n" + $"Horsepower: {vehicle.Horsepower}");
                }
                secondInput = Console.ReadLine();
            }

            double totalCarsHorsePower = 0.00;

            foreach (var item in allCars)
            {
                totalCarsHorsePower += item.Horsepower;
            }

            double totalTrucksHorsePower = 0.00;

            foreach (var item in allTrucks)
            {
                totalTrucksHorsePower += item.Horsepower;
            }

            double avrgHorsePowerForCars = totalCarsHorsePower / allCars.Count;
            double avrgHorsePowerForTrucks = totalTrucksHorsePower / allTrucks.Count;

            if (allCars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {avrgHorsePowerForCars:f2}.");

            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (allTrucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {avrgHorsePowerForTrucks:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }

        class Car
        {
            public string Model { get; set; }
            public string Color { get; set; }
            public double Horsepower { get; set; }

            public string Type { set; get; }

            public Car(string model, string color, double horsepower)
            {
                this.Model = model;
                this.Color = color;
                this.Horsepower = horsepower;
                this.Type = "Car";
            }
        }

        class Truck
        {
            public string Model { get; set; }
            public string Color { get; set; }
            public double Horsepower { get; set; }
            public string Type { set; get; }
            public Truck(string model, string color, double horsepower)
            {
                this.Model = model;
                this.Color = color;
                this.Horsepower = horsepower;
                this.Type = "Truck";
            }
        }
    }
}
