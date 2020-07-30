using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfBarcodes = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"@(#+)([A-Z]{1}[^\W_]{4,}[A-Z]{1})@#+");

            for (int i = 0; i < countOfBarcodes; i++)
            {
                string input = Console.ReadLine();
                Match newMatch = regex.Match(input);

                if (newMatch.Success)
                {
                    Regex matchAllDigits = new Regex(@"\d");
                    MatchCollection allDigits = matchAllDigits.Matches(newMatch.Value);

                    if (allDigits.Count > 0)
                    {
                        StringBuilder group = new StringBuilder();

                        foreach (Match digit in allDigits)
                        {
                            group.Append(digit.Value);
                        }

                        Console.WriteLine($"Product group: {group.ToString()}");
                    }
                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
