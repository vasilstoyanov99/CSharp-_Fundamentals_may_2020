using System;
using System.Collections.Generic;

namespace _03.Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWords = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> wordsAndTheirSynonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfWords; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (wordsAndTheirSynonyms.ContainsKey(word))
                {
                    wordsAndTheirSynonyms[word].Add(synonym);
                }
                else
                {
                    wordsAndTheirSynonyms.Add(word, new List<string>());
                    wordsAndTheirSynonyms[word].Add(synonym);
                }
            }

            foreach (var pair in wordsAndTheirSynonyms)
            {
                Console.WriteLine(pair.Key + " - " + String.Join(", ", pair.Value));
            }
        }
    }
}
