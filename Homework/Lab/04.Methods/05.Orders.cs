using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfOrder = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            TotalOrderSum(typeOfOrder, quantity);
        }

        static void TotalOrderSum(string typeOfOrder, int quantity)
        {
            double totalSum = 0.00;

            switch (typeOfOrder)
            {
                case "coffee":
                    totalSum = 1.50 * quantity;
                    break;
                case "water":
                    totalSum = 1.00 * quantity;
                    break;
                case "coke":
                    totalSum = 1.40 * quantity;
                    break;
                case "snacks":
                    totalSum = 2.00 * quantity;
                    break;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
