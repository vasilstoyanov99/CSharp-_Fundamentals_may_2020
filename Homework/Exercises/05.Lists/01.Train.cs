using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> trainWagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacityPerWagon = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "Add")
                {
                    int passengers = int.Parse(commands[1]);
                    trainWagons.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(commands[0]);

                    for (int currWagon = 0; currWagon < trainWagons.Count; currWagon++)
                    {
                        if (trainWagons[currWagon] + passengers <= maxCapacityPerWagon)
                        {
                            trainWagons[currWagon] += passengers;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", trainWagons));
        }
    }
}
