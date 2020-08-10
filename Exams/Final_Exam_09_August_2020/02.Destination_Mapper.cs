using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace _02.Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex filter = new Regex(@"(?<first>=|\/)(?<destination>[A-Z]{1}[A-Za-z]{2,})\k<first>");
            MatchCollection matches = filter.Matches(input);

            if (matches.Count == 0)
            {
                Console.WriteLine("Destinations:");
                Console.WriteLine("Travel Points: 0");
            }
            else
            {
                List<string> destinations = new List<string>();

                foreach (Match match in matches)
                {
                    destinations.Add(match.Groups["destination"].Value);
                }

                int travelPoints = 0;

                foreach (var destination in destinations)
                {
                    travelPoints += destination.Length;
                }

                Console.WriteLine($"Destinations: {String.Join(", ", destinations)}");
                Console.WriteLine($"Travel Points: {travelPoints}");
            }

        }
    }
}
