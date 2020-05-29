using System;

namespace _04.Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfInputs = int.Parse(Console.ReadLine());
            int asciiCodesSum = 0;

            for (int i = 0; i < numOfInputs; i++)
            {
                char currChar = char.Parse(Console.ReadLine());
                asciiCodesSum += currChar;
            }

            Console.WriteLine($"The sum equals: {asciiCodesSum}");
        }
    }
}
