using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex regex = new Regex(@"(@|#)(?<wordOne>[^\W\d_]{3,})\1\1(?<wordTwo>[^\W\d_]{3,})\1");
            MatchCollection validWordPairs = regex.Matches(text);
            List<string> mirrorWords = new List<string>();

            if (validWordPairs.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{validWordPairs.Count} word pairs found!");
            }

            foreach (Match words in validWordPairs)
            {
                string firstWord = words.Groups["wordOne"].Value;
                string secondWord = words.Groups["wordTwo"].Value;
                string firstWordReversed = new string(firstWord.Reverse().ToArray());
                string secondWordReversed = new string(secondWord.Reverse().ToArray());

                if (firstWordReversed == secondWord)
                {
                    mirrorWords.Add(firstWord);
                    mirrorWords.Add(secondWord);
                    continue;
                }
                else if (secondWordReversed == firstWord)
                {
                    mirrorWords.Add(firstWord);
                    mirrorWords.Add(secondWord);
                    continue;
                }
            }

            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                StringBuilder result = new StringBuilder();
                int index = 0;

                for (int wordIndex = 1; wordIndex <= mirrorWords.Count / 2; wordIndex++)
                {
                    if (index == mirrorWords.Count - 2)
                    {
                        result.Append($"{mirrorWords[mirrorWords.Count - 2]} <=> {mirrorWords[mirrorWords.Count - 1]}");
                    }
                    else
                    {
                        result.Append($"{mirrorWords[index]} <=> {mirrorWords[index + 1]}, ");
                    }

                    index += 2;
                }

                Console.WriteLine("The mirror words are:");
                Console.WriteLine(result.ToString());
            }

        }
    }
}
