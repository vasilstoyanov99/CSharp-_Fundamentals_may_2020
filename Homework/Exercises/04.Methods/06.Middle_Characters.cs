using System;

namespace _06.Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleCharacters(input);
        }

        static void PrintMiddleCharacters(string input)
        {
            if (input.Length % 2 == 0)
            {
                int startIndex = (input.Length / 2) - 1;
                for (int middleChar = startIndex; middleChar <= startIndex + 1; middleChar++)
                {
                    Console.Write(input[middleChar]);
                }
            }
            else
            {
                int startIndex = (input.Length / 2);
                Console.WriteLine(input[startIndex]);
            }
        }
    }
}
