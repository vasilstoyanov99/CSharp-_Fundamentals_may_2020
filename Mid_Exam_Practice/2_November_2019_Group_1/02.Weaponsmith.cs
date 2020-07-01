using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Weaponsmith
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mixedParts = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (data[0])
                {
                    case "Move":
                        if (data[1] == "Left")
                        {
                            MoveLeft(mixedParts, data);
                        }
                        else
                        {
                            MoveRight(mixedParts, data);
                        }
                        break;
                    case "Check":
                        if (data[1] == "Even")
                        {
                            PrintAllElementsAtEvenIndex(mixedParts, data);
                        }
                        else
                        {
                            PrintAllElementsAtOddIndex(mixedParts, data);
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"You crafted {String.Join("", mixedParts)}!");

            static void MoveLeft(List<string> mixedParts, string[] data)
            {
                int index = int.Parse(data[2]);

                if (index >= 1 && index <= mixedParts.Count - 1)
                {
                    string temp = mixedParts[index - 1];
                    mixedParts[index - 1] = mixedParts[index];
                    mixedParts[index] = temp;
                }
            }

            static void MoveRight(List<string> mixedParts, string[] data)
            {
                int index = int.Parse(data[2]);

                if (index >= 0 && index <= mixedParts.Count - 2)
                {
                    string temp = mixedParts[index + 1];
                    mixedParts[index + 1] = mixedParts[index];
                    mixedParts[index] = temp;
                }
            }

            static void PrintAllElementsAtEvenIndex(List<string> mixedParts, string[] data)
            {
                for (int i = 0; i < mixedParts.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{mixedParts[i]} ");
                    }
                }

                Console.WriteLine();
            }

            static void PrintAllElementsAtOddIndex(List<string> mixedParts, string[] data)
            {
                for (int i = 0; i < mixedParts.Count; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write($"{mixedParts[i]} ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
