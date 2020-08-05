using System;
using System.Linq;
using System.Text;

namespace _01Username
{
    class Program
    {
        static void Main(string[] args)
        {
            string toManipulate = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Sign up")
            {
                string[] commands = input.Split().ToArray();

                switch (commands[0])
                {
                    case "Case":
                        toManipulate = MakeAllLettersUpperOrLowerCase(toManipulate, commands[1]);
                        break;
                    case "Reverse":
                        ReverseSubstring(toManipulate, commands);
                        break;
                    case "Cut":
                        toManipulate = RemoveSubstring(toManipulate, commands[1]);
                        break;
                    case "Replace":
                        toManipulate = ReplaceAllOccurencesOfChar(toManipulate, commands);
                        break;
                    case "Check":
                        CheckIfStringContainsChar(toManipulate, commands);
                        break;
                }

                input = Console.ReadLine();
            }
        }

        static string MakeAllLettersUpperOrLowerCase(string toManipulate, string type)
        {
            if (type == "lower")
            {
                string result = toManipulate.ToLower();
                Console.WriteLine(result);
                return result;
            }
            else
            {
                string result = toManipulate.ToUpper();
                Console.WriteLine(result);
                return result;
            }
        }

        static void ReverseSubstring(string toManipulate, string[] commands)
        {
            int startIndex = int.Parse(commands[1]);
            int endIndex = int.Parse(commands[2]);

            bool isStartIndexValid = startIndex >= 0 && startIndex < toManipulate.Length; 
            bool isEndIndexValid = endIndex > 0 && endIndex < toManipulate.Length; 

            if (isStartIndexValid && isEndIndexValid)
            {
                int lenght = endIndex - startIndex + 1;
                string substring = toManipulate.Substring(startIndex, lenght);
                StringBuilder result = new StringBuilder();

                for (int i = substring.Length - 1; i >= 0 ; i--)
                {
                    result.Append(substring[i]);
                }

                Console.WriteLine(result.ToString());
            }
        }

        static string RemoveSubstring(string toManipulate, string substring)
        {
            if (toManipulate.Contains(substring))
            {
                int startIndex = toManipulate.IndexOf(substring);
                string result = toManipulate.Remove(startIndex, substring.Length);
                Console.WriteLine(result);
                return result;
            }
            else
            {
                Console.WriteLine($"The word {toManipulate} doesn't contain {substring}.");
                return toManipulate;
            }
        }

        static string ReplaceAllOccurencesOfChar(string toManipulate, string[] commands)
        {
            char oldChar = char.Parse(commands[1]);
            string result = toManipulate.Replace(oldChar, '*');
            Console.WriteLine(result);
            return result;
        }

        static void CheckIfStringContainsChar(string toManipulate, string[] commands)
        {
            char charToCheck = char.Parse(commands[1]);

            if (toManipulate.Contains(charToCheck))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine($"Your username must contain {charToCheck}.");
            }

        }
    }
}
