using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            Dictionary<char, int> charOccurrences = new Dictionary<char, int>();

            for (int currWordIndex = 0; currWordIndex < words.Length; currWordIndex++)
            {
                for (int currCharIndex = 0; currCharIndex < words[currWordIndex].Length; currCharIndex++)
                {
                    char currChar = words[currWordIndex][currCharIndex];

                    if (charOccurrences.ContainsKey(currChar))
                    {
                        charOccurrences[currChar]++;
                    }
                    else
                    {
                        charOccurrences.Add(currChar, 1);
                    }
                }
            }

            foreach (var pair in charOccurrences)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
