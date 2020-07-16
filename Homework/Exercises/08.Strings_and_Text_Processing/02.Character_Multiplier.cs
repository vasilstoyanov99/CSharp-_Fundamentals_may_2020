using System;
using System.Linq;

namespace _02.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();
            string firstWord = words[0];
            string secondWord = words[1];
            int result = 0;

            if (firstWord.Length == secondWord.Length)
            {
                result = MultiplyAsciiCodesFromEqualLenghtStrings(firstWord, secondWord);
            }
            else
            {
                result = MultiplyAsciiCodesFromNotEqualLenghtStrings(firstWord, secondWord);
            }

            Console.WriteLine(result);
        }

        static int MultiplyAsciiCodesFromEqualLenghtStrings(string firstWord, string secondWord)
        {
            int result = 0;

            for (int i = 0; i < firstWord.Length; i++)
            {
                result += (int)(firstWord[i]) * (int)(secondWord[i]);
            }

            return result;
        }

        static int MultiplyAsciiCodesFromNotEqualLenghtStrings(string firstWord, string secondWord)
        {
            int result = 0;
            string longerString = String.Empty;

            if (firstWord.Length > secondWord.Length && firstWord.Length > 0 && secondWord.Length > 0)
            {
                longerString = firstWord;
            }
            else if (firstWord.Length > 0 && secondWord.Length > 0)
            {
                longerString = secondWord;
            }

            for (int i = 0; i < longerString.Length; i++)
            {
                if (i > firstWord.Length - 1 || i > secondWord.Length - 1)
                {
                    string leftChars = String.Empty;

                    leftChars = longerString.Substring(i, longerString.Length - i);
                    result += ReturnLeftCharsSum(leftChars);
                    break;

                }
                else
                {
                    result += (int)(firstWord[i]) * (int)(secondWord[i]);
                }
            }

            return result;
        }

        static int ReturnLeftCharsSum(string leftChars)
        {
            int sum = 0;

            for (int i = 0; i < leftChars.Length; i++)
            {
                sum += (int)(leftChars[i]);
            }

            return sum;
        }
    }
}
