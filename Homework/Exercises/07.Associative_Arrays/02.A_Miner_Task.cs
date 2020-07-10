using System;
using System.Collections.Generic;

namespace _02.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int linesOfInputCounter = 0;
            Dictionary<string, int> resorcesAndQuantities = new Dictionary<string, int>();
            List<string> resourcesNames = new List<string>();
            int resourceNameIndexCounter = -1;

            while (input != "stop")
            {
                linesOfInputCounter++;

                if (linesOfInputCounter % 2 == 1)
                {
                    string resource = input;
                    resourcesNames.Add(resource);
                    resourceNameIndexCounter++;

                    if (!resorcesAndQuantities.ContainsKey(resource))
                    {
                        resorcesAndQuantities.Add(resource, 0);
                    }
                }
                else
                {
                    int quantity = int.Parse(input);
                    string resourceToAddQuantityTo = resourcesNames[resourceNameIndexCounter];
                    resorcesAndQuantities[resourceToAddQuantityTo] += quantity;
                }

                input = Console.ReadLine();
            }

            foreach (var pair in resorcesAndQuantities)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
