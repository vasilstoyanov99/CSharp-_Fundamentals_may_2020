using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targest = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string input = Console.ReadLine();
            int points = 0;

            while (input != "Game over")
            {
                string[] data = input.Split("@", StringSplitOptions.RemoveEmptyEntries);

                switch (data[0])
                {
                    case "Shoot Left":
                        ShootLeft(targest, data, ref points);
                        break;
                    case "Shoot Right":
                        ShootRight(targest, data, ref points);
                        break;
                    case "Reverse":
                        targest.Reverse();
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" - ", targest));
            Console.WriteLine($"Iskren finished the archery tournament with {points} points!");
        }

        static void ShootLeft(List<int> targest, string[] data, ref int points)
        {
            int startIndex = int.Parse(data[1]);
            int lenght = int.Parse(data[2]);

            if (startIndex >= 0 && startIndex <= targest.Count - 1)
            {
                int targetIndex = 0;

                if (startIndex - lenght < 0)
                {
                    targetIndex = (startIndex - lenght) + targest.Count;
                    targetIndex = Math.Abs(targetIndex);
                    int counter = 0;

                    while (targest.Count < targetIndex)
                    {
                            targetIndex -= targest.Count;
                            counter++;
                    }

                    targetIndex += counter;
                }
                else
                {
                    targetIndex = startIndex - lenght;
                }

                if (targest[targetIndex] > 0 && targest[targetIndex] < 5)
                {
                    points += targest[targetIndex];
                    targest[targetIndex] = 0;
                }
                else if (targest[targetIndex] > 0)
                {
                    targest[targetIndex] -= 5;
                    points += 5;
                }
            }

        }

        static void ShootRight(List<int> targest, string[] data, ref int points)
        {
            int startIndex = int.Parse(data[1]);
            int lenght = int.Parse(data[2]);

            if (startIndex >= 0 && startIndex <= targest.Count - 1)
            {
                int targetIndex = 0;

                if (startIndex == targest.Count - 1)
                {
                    while (lenght > targest.Count)
                    {
                        lenght -= targest.Count;
                    }

                    targetIndex += lenght - 1; 
                }
                else
                {
                    targetIndex = startIndex + lenght;

                    if (targetIndex >= targest.Count - 1)
                    {
                        targetIndex = Math.Abs((startIndex + lenght) - targest.Count);
                        targetIndex--;
                    }
                }

                if (targest[targetIndex] > 0 && targest[targetIndex] < 5)
                {
                    points += targest[targetIndex];
                    targest[targetIndex] = 0;
                }
                else if (targest[targetIndex] > 0)
                {
                    targest[targetIndex] -= 5;
                    points += 5;
                }
            }
        }
    }
}
