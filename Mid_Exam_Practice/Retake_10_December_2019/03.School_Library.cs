using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.School_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shelfWithBooks = Console.ReadLine().Split("&", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] data = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);

                switch (data[0])
                {
                    case "Add Book":
                        AddBook(shelfWithBooks, data);
                        break;
                    case "Take Book":
                        TakeBook(shelfWithBooks, data);
                        break;
                    case "Swap Books":
                        SwapBooks(shelfWithBooks, data);
                        break;
                    case "Insert Book":
                        InsertBook(shelfWithBooks, data);
                        break;
                    case "Check Book":
                        PrintBookAtIndex(shelfWithBooks, data);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", shelfWithBooks));
        }

        static void AddBook(List<string> shelfWithBooks, string[] data) 
        {
            string bookToAdd = data[1];

            if (!shelfWithBooks.Contains(bookToAdd))
            {
                shelfWithBooks.Insert(0, bookToAdd);
            }
        }

        static void TakeBook(List<string> shelfWithBooks, string[] data)
        {
            string bookToTake = data[1];

            if (shelfWithBooks.Contains(bookToTake))
            {
                shelfWithBooks.Remove(bookToTake);
            }
        }

        static void SwapBooks(List<string> shelfWithBooks, string[] data)
        {
            string bookOne = data[1];
            string bookTwo = data[2];

            if (shelfWithBooks.Contains(bookOne) && shelfWithBooks.Contains(bookTwo))
            {
                int indexOfBookOne = shelfWithBooks.IndexOf(bookOne);
                int indexOfBookTwo = shelfWithBooks.IndexOf(bookTwo);
                shelfWithBooks[indexOfBookOne] = bookTwo;
                shelfWithBooks[indexOfBookTwo] = bookOne;
            }
        }

        static void InsertBook(List<string> shelfWithBooks, string[] data)
        {
            string bookToInsert = data[1];
            shelfWithBooks.Add(bookToInsert);
        }

        static void PrintBookAtIndex(List<string> shelfWithBooks, string[] data)
        {
            int index = int.Parse(data[1]);

            if (index >= 0 && index <= shelfWithBooks.Count - 1)
            {
                Console.WriteLine(shelfWithBooks[index]);
            }
        }
    }
}
