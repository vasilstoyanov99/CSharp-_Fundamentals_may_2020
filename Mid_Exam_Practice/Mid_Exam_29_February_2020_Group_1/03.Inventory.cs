using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string input = Console.ReadLine();

            while (input != "Craft!")
            {
                string[] command = input.Split(new char[] { ' ', '-', ':' }, StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Collect":
                        AddItem(inventory, command);
                        break;
                    case "Drop":
                        RemoveItem(inventory, command);
                        break;
                    case "Combine":
                        CombineItems(inventory, command);
                        break;
                    case "Renew":
                        PutItemOnTheLastPosition(inventory, command);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", inventory));
        }

        static void AddItem(List<string> inventory, string[] command)
        {
            string itemToAdd = command[1];

            if (!inventory.Contains(itemToAdd))
            {
                inventory.Add(itemToAdd);
            }
        }

        static void RemoveItem(List<string> inventory, string[] command)
        {
            string itemToRemove = command[1];

            if (inventory.Contains(itemToRemove))
            {
                inventory.Remove(itemToRemove);
            }
        }

        static void CombineItems(List<string> inventory, string[] command)
        {
            string oldItem = command[2];
            string newItem = command[3];

            if (inventory.Contains(oldItem))
            {
                int indexOfOldItem = inventory.IndexOf(oldItem); 
                inventory.Insert(indexOfOldItem + 1, newItem);
            }
        }

        static void PutItemOnTheLastPosition(List<string> inventory, string[] command)
        {
            string item = command[1];

            if (inventory.Contains(item))
            {
                inventory.Remove(item); 
                inventory.Add(item);
            }
        }
    }
}
