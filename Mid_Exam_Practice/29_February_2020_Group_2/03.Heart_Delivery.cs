using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace _03.Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine().Split("@", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string input = String.Empty;
            int cupidStartPosition = 0;

            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int jumpLenght = int.Parse(command[1]);
                int landIndex = cupidStartPosition + jumpLenght;

                if (landIndex > neighborhood.Count - 1)
                {
                    landIndex = 0;
                }

                if (neighborhood[landIndex] == 0)
                {
                    Console.WriteLine($"Place {landIndex} already had Valentine's day.");
                    cupidStartPosition = landIndex;
                    continue;
                }

                neighborhood[landIndex] -= 2;
                cupidStartPosition = landIndex;

                if (neighborhood[landIndex] == 0)
                {
                    Console.WriteLine($"Place {landIndex} has Valentine's day.");
                }
            }

            Console.WriteLine($"Cupid's last position was {cupidStartPosition}.");
            int failedHouses = 0;

            for (int i = 0; i < neighborhood.Count; i++)
            {
                if (neighborhood[i] > 0)
                {
                    failedHouses++;
                }
            }

            if (neighborhood.All(item => item == 0))
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failedHouses} places.");
            }
        }
    }
}
