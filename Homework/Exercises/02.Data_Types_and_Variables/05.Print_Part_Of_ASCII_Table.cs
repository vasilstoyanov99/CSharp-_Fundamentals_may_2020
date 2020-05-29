using System;

namespace _05.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            for (int currCharIndex = startIndex; currCharIndex <= endIndex; currCharIndex++)
            {
                Console.Write($"{(char)currCharIndex} ");
            }
        }
    }
}
