using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            WordsRandomizer newRandomWords = new WordsRandomizer();
            newRandomWords.input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            newRandomWords.RandomiseAndPrint();
        }

        public class WordsRandomizer
        {
           public string[] input;

          public void RandomiseAndPrint()
            {
                Random rand = new Random();

                for (int i = 0; i < input.Length; i++)
                {
                    int randIndex = rand.Next(0, input.Length);
                    string temp = input[i];
                    input[i] = input[randIndex];
                    input[randIndex] = temp;
                }

                Console.WriteLine(String.Join(Environment.NewLine, input));
            }
        }

    }
}
