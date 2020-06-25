using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Car> carsCatalog = new List<Car>();
            List<Truck> trucksCatalog = new List<Truck>();

            while (input != "end")
            {
                string[] data = input.Split(new char[] {' ', '/'}, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (data[0] == "Car")
                {
                    Car newCar = new Car();
                    newCar.Brand = data[1];
                    newCar.Model = data[2];
                    newCar.HorsePower = data[3];
                    carsCatalog.Add(newCar);
                }
                else
                {
                    Truck newTruck = new Truck();
                    newTruck.Brand = data[1]; 
                    newTruck.Model = data[2]; 
                    newTruck.Weight = data[3];
                    trucksCatalog.Add(newTruck);
                }

                input = Console.ReadLine();
            }

            List<Car> carsSorted = carsCatalog.OrderBy(Car => Car.Brand).ToList();
            List<Truck> trucksSorted = trucksCatalog.OrderBy(currTruck => currTruck.Brand).ToList();

            if (carsSorted.Count == 0)
            {
                Console.WriteLine("Trucks: ");

                foreach (var currVehicleInfo in trucksSorted)
                {
                    Console.WriteLine($"{currVehicleInfo.Brand}: {currVehicleInfo.Model} " +
                        $"- {currVehicleInfo.Weight}kg");
                }
            }
            else if (trucksSorted.Count == 0)
            {
                Console.WriteLine("Cars: ");

                foreach (var currVehicleInfo in carsSorted)
                {
                    Console.WriteLine($"{currVehicleInfo.Brand}: {currVehicleInfo.Model} " +
                        $"- {currVehicleInfo.HorsePower}hp");
                }
            }
            else
            {
                Console.WriteLine("Cars: ");

                foreach (var currVehicleInfo in carsSorted)
                {

                    Console.WriteLine($"{currVehicleInfo.Brand}: {currVehicleInfo.Model} " +
                        $"- {currVehicleInfo.HorsePower}hp");
                }

                Console.WriteLine("Trucks: ");

                foreach (var currVehicleInfo in trucksSorted)
                {
                    Console.WriteLine($"{currVehicleInfo.Brand}: {currVehicleInfo.Model} " +
                             $"- {currVehicleInfo.Weight}kg");
                }
            }
        }

        public class Truck
        {
           public string Brand { get; set; }
           public string Model { get; set; }
           public string Weight { get; set; }
        }

        public class Car
        {
           public string Brand { get; set; }
           public string Model { get; set; }
           public string HorsePower { get; set; }
        }
    }
}
