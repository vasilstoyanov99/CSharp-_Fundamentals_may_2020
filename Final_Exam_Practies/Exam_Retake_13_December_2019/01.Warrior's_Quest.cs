using System;
using System.Linq;
using System.Text;

namespace _01.Warrior_s_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            string skillToDecode = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "For Azeroth")
            {
                string[] commands = input.Split().ToArray();

                switch (commands[0])
                {
                    case "GladiatorStance":
                        skillToDecode = MakeAllLettersUpperCase(skillToDecode);
                        break;
                    case "DefensiveStance":
                        skillToDecode = MakeAllLettersLowerCase(skillToDecode);
                        break;
                    case "Dispel":
                        skillToDecode = ReplaceALetter(skillToDecode, commands);
                        break;
                    case "Target":
                        if (commands[1] == "Change")
                        {
                            skillToDecode = ReplaceSubstring(skillToDecode, commands);
                        }
                        else if (commands[1] == "Remove")
                        {
                            skillToDecode = RemoveSubstring(skillToDecode, commands);
                        }
                        break;
                    default:
                        Console.WriteLine("Command doesn't exist!");
                        break;
                }

                input = Console.ReadLine();
            }
        }

        static string MakeAllLettersUpperCase(string skillToDecode)
        {
            string result = skillToDecode.ToUpper();
            Console.WriteLine(result);
            return result;
        }

        static string MakeAllLettersLowerCase(string skillToDecode)
        {
            string result = skillToDecode.ToLower();
            Console.WriteLine(result);
            return result;
        }

        static string ReplaceALetter(string skillToDecode, string[] commands)
        {
            int index = int.Parse(commands[1]);
            char newLetter = char.Parse(commands[2]);

            if (index >= 0 && index < skillToDecode.Length)
            {
                StringBuilder result = new StringBuilder(skillToDecode);
                result[index] = newLetter;
                Console.WriteLine("Success!");
                return result.ToString();
            }
            else
            {
                Console.WriteLine("Dispel too weak.");
                return skillToDecode;
            }
        }

        static string ReplaceSubstring(string skillToDecode, string[] commands)
        {
            string oldSubstring = commands[2];
            string newSubstring = commands[3];
            string result = skillToDecode.Replace(oldSubstring, newSubstring);
            Console.WriteLine(result);
            return result;
        }

        static string RemoveSubstring(string skillToDecode, string[] commands)
        {
            string substringToRemove = commands[2];
            int startIndex = skillToDecode.IndexOf(substringToRemove);
            string result = skillToDecode.Remove(startIndex, substringToRemove.Length);
            Console.WriteLine(result);
            return result;
        }
    }
}
