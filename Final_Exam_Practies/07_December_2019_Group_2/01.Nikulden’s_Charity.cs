using System;
using System.Linq;

namespace _01.Nikulden_s_Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            string toDecrypt = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Finish")
            {
                string[] commands = input.Split().ToArray();

                switch (commands[0])
                {
                    case "Replace":
                        toDecrypt = ReplaceChar(toDecrypt, commands);
                        break;
                    case "Cut":
                        toDecrypt = RemoveSubstring(toDecrypt, commands);
                        break;
                    case "Make":
                        toDecrypt = MakeAllLettersUpperOrLowerCase(toDecrypt, commands);
                        break;
                    case "Check":
                        CheckIfContainsString(toDecrypt, commands);
                        break;
                    case "Sum":
                        SumAscii(toDecrypt, commands);
                        break;
                }

                input = Console.ReadLine();
            }
        }

        static string ReplaceChar(string toDecrypt, string[] commands)
        {
            char oldChar = char.Parse(commands[1]);
            char newChar = char.Parse(commands[2]);
            string result = toDecrypt.Replace(oldChar, newChar);
            Console.WriteLine(result);
            return result;
        }

        static string RemoveSubstring(string toDecrypt, string[] commands)
        {
            int startIndex = int.Parse(commands[1]);
            int endIndex = int.Parse(commands[2]);
            bool isStartIndexValid = startIndex >= 0 && startIndex < toDecrypt.Length;
            bool isEndIndexValid = endIndex > 0 && endIndex < toDecrypt.Length; // може да иска да е и равно на 0

            if (isStartIndexValid && isEndIndexValid)
            {
                int lenght = endIndex - startIndex + 1;
                int aa = toDecrypt.Length;
                string result = toDecrypt.Remove(startIndex, lenght);
                Console.WriteLine(result);
                return result;
            }
            else
            {
                Console.WriteLine("Invalid indexes!");
                return toDecrypt;
            }
        }

        static string MakeAllLettersUpperOrLowerCase(string toDecrypt, string[] commands)
        {
            if (commands[1] == "Upper")
            {
                string resultUpperCase = toDecrypt.ToUpper();
                Console.WriteLine(resultUpperCase);
                return resultUpperCase;
            }
            else
            {
                string resultLowerCase = toDecrypt.ToLower();
                Console.WriteLine(resultLowerCase);
                return resultLowerCase;
            }
        }

        static void CheckIfContainsString(string toDecrypt, string[] commands)
        {
            string toCheck = commands[1];

            if (toDecrypt.Contains(toCheck))
            {
                Console.WriteLine($"Message contains {toCheck}");
            }
            else
            {
                Console.WriteLine($"Message doesn't contain {toCheck}");
            }
        }

        static void SumAscii(string toDecrypt, string[] commands)
        {
            int startIndex = int.Parse(commands[1]);
            int endIndex = int.Parse(commands[2]);
            bool isStartIndexValid = startIndex >= 0 && startIndex < toDecrypt.Length;
            bool isEndIndexValid = endIndex > 0 && endIndex < toDecrypt.Length;

            if (isStartIndexValid && isEndIndexValid)
            {
                int lenght = endIndex - startIndex + 1;
                string substring = toDecrypt.Substring(startIndex, endIndex);
                int asciiSum = 0;

                for (int i = 0; i < substring.Length; i++)
                {
                    asciiSum += substring[i];
                }

                Console.WriteLine(asciiSum);
            }
            else
            {
                Console.WriteLine("Invalid indexes!");
            }
        }
    }
}
