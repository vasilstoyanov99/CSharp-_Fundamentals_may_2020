using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03.SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex validator = new Regex(@"^%(?<name>[A-Z]{1}[a-z]+)%([^|$%\.]*)<(?<product>\w+)>([^|$%\.]*)\|(?<quantity>[1-9]+[0-9]*)\|([^|$%\.]*?)(?<price>[1-9]+[0-9]*\.?\d*)\$$");
            decimal totalIncome = 0;

            while (input != "end of shift")
            {
                Match newPurchase = validator.Match(input);

                if (newPurchase.Success)
                {
                    string buyerName = newPurchase.Groups["name"].Value;
                    string productName = newPurchase.Groups["product"].Value;
                    long quantity = long.Parse(newPurchase.Groups["quantity"].Value);
                    decimal pricePerPiece = decimal.Parse(newPurchase.Groups["price"].Value);
                    decimal totalPrice = quantity * pricePerPiece;
                    Console.WriteLine($"{buyerName}: {productName} - {totalPrice:f2}");
                    totalIncome += totalPrice;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
