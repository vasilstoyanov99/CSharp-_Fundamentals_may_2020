using System;
using System.Text.RegularExpressions;

namespace _03.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(\d{2})(\.|-|\/)([A-Z][a-z]{2})\2(\d{4})");
            MatchCollection validDates = regex.Matches(input);

            foreach (Match date in validDates)
            {
                Console.WriteLine($"Day: {date.Groups[1].Value}, Month: {date.Groups[3].Value}, Year: {date.Groups[4].Value}");
            }
        }
    }
}
