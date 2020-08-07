using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.Message_Encrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            Regex validator = new Regex(@"^.*?(\*|@)(?<Tag>[A-Z]{1}[a-z]{2,})\1: \[(?<firstLetter>[^\W_]{1})\]\|\[(?<secondLetter>[^\W_]{1})\]\|\[(?<thirdLetter>[^\W_]{1})\]\|$");

            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();
                Match match = validator.Match(input);

                if (match.Success)
                {
                    List<int> lettersAscii = new List<int>();
                    lettersAscii.Add(match.Groups["firstLetter"].Value[0]);
                    lettersAscii.Add(match.Groups["secondLetter"].Value[0]);
                    lettersAscii.Add(match.Groups["thirdLetter"].Value[0]);
                    Console.WriteLine($"{match.Groups["Tag"].Value}: {String.Join(" ", lettersAscii)}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
