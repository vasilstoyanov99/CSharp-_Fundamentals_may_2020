using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split().ToArray();
            Dictionary<string, int> allOccurrences = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (allOccurrences.ContainsKey(word))
                {
                    allOccurrences[word]++;
                }
                else
                {
                    allOccurrences.Add(word, 1);
                }
            }

            foreach (var pair in allOccurrences)
            {
                if (pair.Value % 2 == 1)
                {
                    Console.Write(pair.Key + " ");
                }
            }
        }
    }
}
