using System;

namespace _02.Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(VowelsCounter(input));
        }

        static int VowelsCounter(string input)
        {
            int vowelsCounter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                bool isUpperCaseVowel = currChar == 'A' || currChar == 'E' || currChar == 'I' || currChar == 'U' || currChar == 'O';
                bool isLowerCaseVowel = currChar == 'a' || currChar == 'e' || currChar == 'i' || currChar == 'u' || currChar == 'o';

                if (isUpperCaseVowel || isLowerCaseVowel)
                {
                    vowelsCounter++;
                }
            }

            return vowelsCounter;
        }
    }
}
