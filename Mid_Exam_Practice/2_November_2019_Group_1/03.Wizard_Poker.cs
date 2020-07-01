using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Wizard_Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> allCards = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> newDeck = new List<string>();
            string input = Console.ReadLine();

            while (input != "Ready")
            {
                string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (data[0])
                {
                    case "Add":
                        AddCard(allCards, newDeck, data);
                        break;
                    case "Insert":
                        InsertCard(allCards, newDeck, data);
                        break;
                    case "Remove":
                        RemoveCard(allCards, newDeck, data);
                        break;
                    case "Swap":
                        SwapCards(allCards, newDeck, data);
                        break;
                    case "Shuffle":
                        newDeck.Reverse();
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", newDeck));
        }

        static void AddCard(List<string> allCards, List<string> newDeck, string[] data)
        {
            string newCard = data[1];

            if (allCards.Contains(newCard))
            {
                newDeck.Add(newCard);
            }
            else
            {
                Console.WriteLine("Card not found.");
                return;
            }
        }

        static void InsertCard(List<string> allCards, List<string> newDeck, string[] data)
        {
            string cardToInsert = data[1];
            int atIndex = int.Parse(data[2]);

            if (atIndex >= 0 && atIndex <= newDeck.Count - 1)
            {
                if (!allCards.Contains(cardToInsert))
                {
                    Console.WriteLine("Error!");
                    return;
                }
                else
                {
                    newDeck.Insert(atIndex, cardToInsert);
                }
            }
            else
            {
                Console.WriteLine("Error!");
                return;
            }
        }

        static void RemoveCard(List<string> allCards, List<string> newDeck, string[] data)
        {
            string cardToRemove = data[1];

            if (!newDeck.Contains(cardToRemove))
            {
                Console.WriteLine("Card not found.");
                return;
            }
            else
            {
                newDeck.Remove(cardToRemove);
            }
        }

        static void SwapCards(List<string> allCards, List<string> newDeck, string[] data)
        {
            string fisrtCard = data[1];
            string secondCard = data[2];
            int indexOfFirstCard = newDeck.IndexOf(fisrtCard);
            int indexOfSecondCard = newDeck.IndexOf(secondCard);
            newDeck[indexOfFirstCard] = secondCard;
            newDeck[indexOfSecondCard] = fisrtCard;
        }
    }
}
