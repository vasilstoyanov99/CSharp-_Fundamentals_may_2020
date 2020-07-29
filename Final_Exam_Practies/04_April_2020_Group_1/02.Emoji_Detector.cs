using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02.Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(::|\*\*)(?<emoji>[A-Z]{1}[a-z]{2,})\1");
            MatchCollection allValidEmojis = regex.Matches(input);
            Regex matchAllDigits = new Regex(@"(?<digit>\d)");
            MatchCollection allDigits = matchAllDigits.Matches(input);
            BigInteger coolThreshold = new BigInteger(1); 

            foreach (Match digit in allDigits)
            {
                coolThreshold *= int.Parse(digit.Groups["digit"].Value);
            }

            List<string> allCoolEmojis = new List<string>();

            foreach (Match emoji in allValidEmojis)
            {
                BigInteger coolness = new BigInteger();
                string currEmoji = emoji.Groups["emoji"].Value;

                for (int i = 0; i < currEmoji.Length; i++)
                {
                    coolness += currEmoji[i];
                }

                if (coolness > coolThreshold) 
                {
                    allCoolEmojis.Add(emoji.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{allValidEmojis.Count} emojis found in the text. The cool ones are:");

            if (allCoolEmojis.Count > 0)
            {
                foreach (var emoji in allCoolEmojis)
                {
                    Console.WriteLine(emoji);
                }
            }
        }
    }
}
