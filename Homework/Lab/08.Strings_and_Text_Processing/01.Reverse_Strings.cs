using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                words.Add(input);
                input = Console.ReadLine();
            }

            foreach (var word in words)
            {
                StringBuilder reversedWord = new StringBuilder();

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversedWord.Append(word[i]);
                }

                Console.WriteLine(word + " = " + reversedWord.ToString());
            }
        }
    }
}
