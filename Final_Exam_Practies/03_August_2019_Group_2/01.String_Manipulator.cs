using System;
using System.Collections.Immutable;
using System.Linq;

namespace _01.String_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string toManipulate = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] commands = input.Split().ToArray();

                switch (commands[0])
                {
                    case "Change":
                        toManipulate = ReplaceAllOldChars(toManipulate, commands);
                        break;
                    case "Includes":
                        CheckIfContains(toManipulate, commands[1]);
                        break;
                    case "End":
                        CheckIfStringEndsWith(toManipulate, commands[1]);
                        break;
                    case "Uppercase":
                        toManipulate = MakeAllLettersUpperCase(toManipulate);
                        break;
                    case "FindIndex":
                        char toFind = char.Parse(commands[1]);
                        FindIndexOfChar(toManipulate, toFind);
                        break;
                    case "Cut":
                        toManipulate = GetSubstring(toManipulate, commands);
                        break;
                }

                input = Console.ReadLine();
            }
        }

        static string ReplaceAllOldChars(string toManipulate, string[] commands)
        {
            char oldChar = char.Parse(commands[1]); 
            char newChar = char.Parse(commands[2]);
            string result = toManipulate.Replace(oldChar, newChar);
            Console.WriteLine(result);
            return result;
        }

        static void CheckIfContains(string toManipulate, string toCheck)
        {
            if (toManipulate.Contains(toCheck))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static void CheckIfStringEndsWith(string toManipulate, string toCheck)
        {
            int startIndex = toManipulate.Length - toCheck.Length;
            int lenght = toManipulate.Length - startIndex;
            string endsWith = toManipulate.Substring(startIndex, lenght);

            if (toCheck == endsWith)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static string MakeAllLettersUpperCase(string toManipulate)
        {
            string result = toManipulate.ToUpper();
            Console.WriteLine(result);
            return result;
        }

        static void FindIndexOfChar(string toManipulate, char toFindIndexOf)
        {
            int indexOf = toManipulate.IndexOf(toFindIndexOf);
            Console.WriteLine(indexOf);
        }

        static string GetSubstring(string toManipulate, string[] commands)
        {
            int startIndex = int.Parse(commands[1]);
            int lenght = int.Parse(commands[2]);
            string result = toManipulate.Substring(startIndex, lenght);
            Console.WriteLine(result);
            return result;
        }
    }
}
