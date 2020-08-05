using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            Regex validator = new Regex(@"^(.+)>(?<onlyNumbers>\d+)\|(?<onlyLowerCase>[a-z]+)\|(?<onlyUpperCase>[A-Z]+)\|(?<onlyOtherSymbols>[^<>]+)<\1$");

            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();
                Match match = validator.Match(input);

                if (match.Success)
                {
                    StringBuilder encrypted = new StringBuilder();
                    encrypted.Append(match.Groups["onlyNumbers"].Value);
                    encrypted.Append(match.Groups["onlyLowerCase"].Value);
                    encrypted.Append(match.Groups["onlyUpperCase"].Value);
                    encrypted.Append(match.Groups["onlyOtherSymbols"].Value);
                    Console.WriteLine($"Password: {encrypted.ToString()}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
