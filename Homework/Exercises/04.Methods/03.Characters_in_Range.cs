using System;

namespace _03.Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char x = char.Parse(Console.ReadLine());
            char y = char.Parse(Console.ReadLine());
            PrintAllCharBetween(x, y);
        }

        static void PrintAllCharBetween(int x, int y)
        {
            if (x < y)
            {
                for (int i = x + 1; i < y; i++)
                {
                    char currChar = (char)i;
                    Console.Write(currChar + " ");

                }
            }
            else if (x > y)
            {
                for (int i = y + 1; i < x; i++)
                {
                    char currChar = (char)i;
                    Console.Write(currChar + " ");

                }
            }

        }
    }
}
