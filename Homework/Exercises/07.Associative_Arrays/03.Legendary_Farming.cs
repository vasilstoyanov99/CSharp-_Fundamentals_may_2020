using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<string, int> preciousMaterials = new SortedDictionary<string, int>();
            SortedDictionary<string, int> junkMaterials = new SortedDictionary<string, int>();
            preciousMaterials.Add("shards", 0);
            preciousMaterials.Add("fragments", 0);
            preciousMaterials.Add("motes", 0);
            bool isQuantityOfPreciousMaterialReached = false;
            string LegendaryItemName = String.Empty;

            while (true)
            {
                string[] data = input.Split();
                int quantityIndexCounter = 0;
                int materialNameIndexCounter = 1;

                for (int currMaterialData = 1; currMaterialData <= data.Length / 2; currMaterialData++)
                {
                    int quantity = int.Parse(data[quantityIndexCounter]);
                    string materialName = data[materialNameIndexCounter].ToLower();
                    quantityIndexCounter += 2;
                    materialNameIndexCounter += 2;

                    if (materialName == "shards" || materialName == "fragments" || materialName == "motes")
                    {
                        preciousMaterials[materialName] += quantity;

                        if (preciousMaterials[materialName] >= 250)
                        {
                            isQuantityOfPreciousMaterialReached = true;
                            LegendaryItemName = materialName;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(materialName))
                        {
                            junkMaterials.Add(materialName, quantity);
                        }
                        else
                        {
                            junkMaterials[materialName] += quantity;
                        }
                    }

                    if (isQuantityOfPreciousMaterialReached == true)
                    {
                        PrintOutput(preciousMaterials, junkMaterials, LegendaryItemName);
                        return;
                    }

                }

                input = Console.ReadLine();
            }
        }

        static void PrintOutput(SortedDictionary<string, int> preciousMaterials, SortedDictionary<string, int> junkMaterial,
            string LegendaryItemName)
        {
            if (LegendaryItemName == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
                preciousMaterials[LegendaryItemName] -= 250;
            }
            else if (LegendaryItemName == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
                preciousMaterials[LegendaryItemName] -= 250;
            }
            else
            {
                Console.WriteLine("Dragonwrath obtained!");
                preciousMaterials[LegendaryItemName] -= 250;
            }

            foreach (KeyValuePair<string, int> pair in preciousMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Value))
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }

            foreach (var pair in junkMaterial)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }
        }
    }
}
