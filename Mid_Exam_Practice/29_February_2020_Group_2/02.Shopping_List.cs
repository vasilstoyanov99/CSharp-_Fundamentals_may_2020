using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace _02.Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (commands[0])
                {
                    case "Urgent":
                        AddItem(shoppingList, commands);
                        break;
                    case "Unnecessary":
                        RemoveItem(shoppingList, commands);
                        break;
                    case "Correct":
                        CorrectItem(shoppingList, commands);
                        break;
                    case "Rearrange":
                        RearrangeItem(shoppingList, commands);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", shoppingList));

        }
            static void AddItem(List<string> shoppingList, string[] commands)
            {
                string itemToAdd = commands[1];

                if (!shoppingList.Contains(itemToAdd))
                {
                    shoppingList.Insert(0, itemToAdd);
                }
                else
                {
                    return;
                }
            }

            static void RemoveItem(List<string> shoppingList, string[] commands)
            {
                string itemToRemove = commands[1];

                if (shoppingList.Contains(itemToRemove))
                {
                int itemToRemoveIndex = shoppingList.IndexOf(itemToRemove);
                shoppingList.Remove(itemToRemove);
                }
                else
                {
                    return;
                }
            }

            static void CorrectItem(List<string> shoppingList, string[] commands)
            {
                string oldItem = commands[1];
                string newItem = commands[2];

                if (shoppingList.Contains(oldItem))
                {
                    int oldItemIndex = shoppingList.IndexOf(oldItem);
                shoppingList[oldItemIndex] = "";
                shoppingList[oldItemIndex] = newItem;
                }
                else
                {
                    return;
                }
            }

            static void RearrangeItem(List<string> shoppingList, string[] commands)
            {
                string itemToRearrange = commands[1];

                if (shoppingList.Contains(itemToRearrange))
                {
                    int itemToRearrangeIndex = shoppingList.IndexOf(itemToRearrange);
                    shoppingList.RemoveAt(itemToRearrangeIndex);
                    shoppingList.Add(itemToRearrange);
                }
                else
                {
                    return;
                }
            }
    }
}
