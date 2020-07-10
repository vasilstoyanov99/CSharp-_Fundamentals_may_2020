using System;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> productsData = new Dictionary<string, Product>();
            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] data = input.Split();
                string productName = data[0];
                double productPrice = double.Parse(data[1]);
                int productQuantity = int.Parse(data[2]);

                if (productsData.ContainsKey(productName))
                {
                    productsData[productName].Quantity += productQuantity;

                    if (productsData[productName].Price != productPrice)
                    {
                        productsData[productName].Price = productPrice;
                    }
                }
                else
                {
                    Product newProduct = new Product(productPrice, productQuantity);
                    productsData.Add(productName, newProduct);

                }

                input = Console.ReadLine();
            }

            foreach (var pair in productsData)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value.Price * pair.Value.Quantity:f2}");
            }
        }
    }

    class Product
    {
        public Product(double price, int quantity)
        {
            this.Price = price;
            this.Quantity = quantity;
        }
        public double Price { set; get; }
        public int Quantity { set; get; }
    }
}
