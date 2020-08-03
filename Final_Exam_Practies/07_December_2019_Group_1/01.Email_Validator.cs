using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Email_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string toManipulate = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Complete")
            {
                string[] commands = input.Split().ToArray();

                switch (commands[0])
                {
                    case "Make":
                        toManipulate = MakeAllLettersUpperOrLowerCase(toManipulate, commands[1]);
                        break;
                    case "GetDomain":
                        PrintTheLastLetters(toManipulate, commands);
                        break;
                    case "GetUsername":
                        PrintTheUsername(toManipulate);
                        break;
                    case "Replace":
                        toManipulate = ReplaceAllOccurences(toManipulate, commands);
                        break;
                    case "Encrypt":
                        PrintAllAsciiValuesOfEachSymbol(toManipulate);
                        break;
                }

                input = Console.ReadLine();
            }
        }

        static string MakeAllLettersUpperOrLowerCase(string toManipulate, string type)
        {
            if (type == "Upper")
            {
                string result = toManipulate.ToUpper();
                Console.WriteLine(result);
                return result;
            }
            else
            {
                string result = toManipulate.ToLower();
                Console.WriteLine(result);
                return result;
            }
        }

        static void PrintTheLastLetters(string toManipulate, string[] commands)
        {
            int count = int.Parse(commands[1]);
            int startIndex = toManipulate.Length - count;
            StringBuilder result = new StringBuilder();

            for (int i = startIndex; i < toManipulate.Length; i++)
            {
                result.Append(toManipulate[i]);
            }

            Console.WriteLine(result);
        }

        static void PrintTheUsername(string toManipulate)
        {
            if (toManipulate.Contains('@'))
            {
                int endIndex = toManipulate.IndexOf('@');
                StringBuilder username = new StringBuilder();

                for (int i = 0; i < endIndex; i++)
                {
                    username.Append(toManipulate[i]);
                }

                Console.WriteLine(username.ToString());

            }
            else
            {
                Console.WriteLine($"The email {toManipulate} doesn't contain the @ symbol.");
            }
        }

        static string ReplaceAllOccurences(string toManipulate, string[] commands)
        {
            char oldChar = char.Parse(commands[1]);
            string result = toManipulate.Replace(oldChar, '-');
            Console.WriteLine(result);
            return result;
        }

        static void PrintAllAsciiValuesOfEachSymbol(string toManipulate)
        {
            List<int> allAsciiValues = new List<int>();

            for (int i = 0; i < toManipulate.Length; i++)
            {
                allAsciiValues.Add(toManipulate[i]);
            }

            Console.WriteLine(String.Join(" ", allAsciiValues));
        }
    }
}
