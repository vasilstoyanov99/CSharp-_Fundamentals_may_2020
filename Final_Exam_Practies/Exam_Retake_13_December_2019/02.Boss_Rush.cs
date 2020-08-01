using System;
using System.Text.RegularExpressions;

namespace _02.Boss_Rush
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"\|(?<bossName>[A-Z]{4,})\|:#(?<title>[^\W\d_]+ [^\W\d_]+)#");

            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();
                Match isValid = regex.Match(input);

                if (isValid.Success)
                {
                    string bossName = isValid.Groups["bossName"].Value;
                    string title = isValid.Groups["title"].Value;
                    Console.WriteLine($"{bossName}, The {title}");
                    Console.WriteLine($">> Strength: {bossName.Length}");
                    Console.WriteLine($">> Armour: {title.Length}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
