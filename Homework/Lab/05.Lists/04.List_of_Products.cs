using System;
using System.Collections.Generic;

namespace _04.List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            byte nLinesOfInput = byte.Parse(Console.ReadLine());
            List<string> products = new List<string>();

            for (int i = 0; i < nLinesOfInput; i++)
            {
                products.Add(Console.ReadLine());
            }

            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
