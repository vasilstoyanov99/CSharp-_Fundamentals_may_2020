using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Message_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOMessages = int.Parse(Console.ReadLine());
            Regex validator = new Regex(@"^!(?<command>[A-Z]{1}[a-z]{2,})!:\[(?<message>[A-Za-z]{8,})\]$");

            for (int i = 0; i < numberOMessages; i++)
            {
                string messageToValidate = Console.ReadLine();
                Match match = validator.Match(messageToValidate);

                if (match.Success)
                {
                    StringBuilder output = new StringBuilder();
                    output.Append($"{match.Groups["command"].Value}: ");
                    string message = match.Groups["message"].Value;

                    for (int currChar = 0; currChar < message.Length; currChar++)
                    {
                        int ascii = message[currChar];
                        output.Append($"{ascii} ");
                    }

                    Console.WriteLine(output.ToString());
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
