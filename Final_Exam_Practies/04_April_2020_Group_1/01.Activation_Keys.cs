using System;
using System.Linq;
using System.Text;

namespace _01.Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawKey = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Generate")
            {
                
                string[] commands = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commands[0] == "Contains")
                {
                    CheckIfKeyContains(commands[1], rawKey);
                }
                else if (commands[0] == "Flip")
                {
                    if (commands[1] == "Upper")
                    {
                        FlipToUpperCase(ref rawKey, commands);
                    }
                    else
                    {
                        FlipToLowerCase(ref rawKey, commands);
                    }
                }
                else if (commands[0] == "Slice")
                {
                    DeleteSubstring(ref rawKey, commands);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {rawKey}");
        }

        static void CheckIfKeyContains(string substring, string rawKey)
        {
            if (rawKey.Contains(substring))
            {
                Console.WriteLine($"{rawKey} contains {substring}");
            }
            else
            {
                Console.WriteLine("Substring not found!");
            }
        }

        static void FlipToUpperCase(ref string rawKey, string[] commands)
        {
            int startIndex = int.Parse(commands[2]);
            int endIndex = int.Parse(commands[3]);
            string substringToFlip = rawKey.Substring(startIndex, endIndex - startIndex);
            rawKey = rawKey.Replace(substringToFlip, substringToFlip.ToUpper());
            Console.WriteLine(rawKey);
        }

        static void FlipToLowerCase(ref string rawKey, string[] commands)
        {
            int startIndex = int.Parse(commands[2]);
            int endIndex = int.Parse(commands[3]);
            string substringToFlip = rawKey.Substring(startIndex, endIndex - startIndex);
            rawKey = rawKey.Replace(substringToFlip, substringToFlip.ToLower());
            Console.WriteLine(rawKey);
        }

        static void DeleteSubstring(ref string rawKey, string[] commands)
        {
            int startIndex = int.Parse(commands[1]);
            int endIndex = int.Parse(commands[2]);
            rawKey = rawKey.Remove(startIndex, endIndex - startIndex);
            Console.WriteLine(rawKey);
        }
    }
}
