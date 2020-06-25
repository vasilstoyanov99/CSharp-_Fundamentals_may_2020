using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> allItemsData = new List<Box>();

            while (input != "end")
            {
                string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Box newItemData = new Box();
                newItemData.SerialNumber = int.Parse(data[0]);
                newItemData.Item.Name = data[1];
                newItemData.ItemQuantity = int.Parse(data[2]);
                newItemData.Item.Price = double.Parse(data[3]);
                allItemsData.Add(newItemData);
                newItemData.PriceForABox = newItemData.ItemQuantity * newItemData.Item.Price;

                input = Console.ReadLine();
            }

           List<Box> SortedByDescendingPriceOrder = allItemsData.OrderByDescending(i => i.PriceForABox).ToList();

            foreach (var currBoxData in SortedByDescendingPriceOrder)
            {
                Console.WriteLine($"{currBoxData.SerialNumber}");
                Console.WriteLine($"-- {currBoxData.Item.Name} - ${currBoxData.Item.Price:f2}: {currBoxData.ItemQuantity}");
                Console.WriteLine($"-- ${currBoxData.PriceForABox:f2}");
            }
        }

        public class Item
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }

        public class Box
        {
            public Box()
            {
                Item = new Item();
            }

            public int SerialNumber { get; set; }
            public int ItemQuantity { get; set; }
            public double PriceForABox { get; set; }

            public Item Item { get; set; }
        }
    }
}
