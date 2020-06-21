using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayerDeck = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstPlayerDeck.Count > 0 && secondPlayerDeck.Count > 0)
            {
                int biggerCard = Math.Max(firstPlayerDeck[0], secondPlayerDeck[0]);

                if (firstPlayerDeck[0] == secondPlayerDeck[0])
                {
                    firstPlayerDeck.Remove(secondPlayerDeck[0]);
                    secondPlayerDeck.Remove(secondPlayerDeck[0]);
                    continue;
                }

                if (firstPlayerDeck[0] == biggerCard)
                {
                    int firstPlayerCard = firstPlayerDeck[0];
                    int secondPlayerCard = secondPlayerDeck[0];
                    firstPlayerDeck.RemoveAt(0);
                    firstPlayerDeck.Add(firstPlayerCard);
                    firstPlayerDeck.Add(secondPlayerCard);
                    secondPlayerDeck.RemoveAt(0);
                }
                else if (secondPlayerDeck[0] == biggerCard)
                {
                    int firstPlayerCard = firstPlayerDeck[0];
                    int secondPlayerCard = secondPlayerDeck[0];
                    secondPlayerDeck.RemoveAt(0);
                    secondPlayerDeck.Add(secondPlayerCard);
                    secondPlayerDeck.Add(firstPlayerCard);
                    firstPlayerDeck.RemoveAt(0);
                }

            }

            if (firstPlayerDeck.Count == 0)
            {
                int winnerSum = secondPlayerDeck.Sum();
                Console.WriteLine($"Second player wins! Sum: {winnerSum}");
            }
            else
            {
                int winnerSum = firstPlayerDeck.Sum();
                Console.WriteLine($"First player wins! Sum: {winnerSum}");
            }
        }
    }
}
