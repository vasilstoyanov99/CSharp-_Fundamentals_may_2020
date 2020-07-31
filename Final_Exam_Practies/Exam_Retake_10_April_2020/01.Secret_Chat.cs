using System;
using System.Linq;
using System.Security.Cryptography;

namespace _01.Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string messageToDecode = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Reveal")
            {
                string[] commands = input.Split(":|:", StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (commands[0])
                {
                    case "InsertSpace":
                        messageToDecode = InsertSpace(messageToDecode, commands);
                        break;
                    case "Reverse":
                        messageToDecode = Reverse(messageToDecode, commands);
                        break;
                    case "ChangeAll":
                        messageToDecode = ChangeAllOccurrences(messageToDecode, commands);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {messageToDecode}");
        }

        static string InsertSpace(string messageToDecode, string[] commands)
        {
            int atIndex = int.Parse(commands[1]);
            messageToDecode = messageToDecode.Insert(atIndex, " ");
            Console.WriteLine(messageToDecode);
            return messageToDecode;
        }

        static string Reverse(string messageToDecode, string[] commands)
        {
            string substring = commands[1];

            if (messageToDecode.Contains(substring))
            {
                int startIndex = messageToDecode.IndexOf(substring);
                messageToDecode = messageToDecode.Remove(startIndex, substring.Length);
                string reversedSubstring = new string(substring.Reverse().ToArray());
                messageToDecode = messageToDecode.Insert(messageToDecode.Length, reversedSubstring);
                Console.WriteLine(messageToDecode);
                return messageToDecode;
            }
            else
            {
                Console.WriteLine("error");
                return messageToDecode;
            }
        }

        static string ChangeAllOccurrences(string messageToDecode, string[] commands)
        {
           string oldSubstring = commands[1];
           string newSubstring = commands[2];
           messageToDecode = messageToDecode.Replace(oldSubstring, newSubstring);
           Console.WriteLine(messageToDecode);
            return messageToDecode;

        }
    }
}
