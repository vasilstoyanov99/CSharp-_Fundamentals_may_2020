using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesOfInput = int.Parse(Console.ReadLine());
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < linesOfInput; i++)
            {
                string input = Console.ReadLine().Trim();
                string decodedMessage = Decrypt(input);
                Regex regex = new Regex(@"^[^@\-!:>]*@(?<planetName>[A-z]+)[^@\-!:>]*:[^@\-!:>\d]*(?<population>\d+)[^@\-!:>]*![^@\-!:>]*(?<attackType>A|D)[^@\-!:>]*!->[^@\-!:>\d]*(?<soldiersCount>\d+)[^@\-!:>]*$");
                Match newMatch = regex.Match(decodedMessage);

                if (newMatch.Success)
                {
                    if (newMatch.Groups["attackType"].Value == "A")
                    {
                        attackedPlanets.Add(newMatch.Groups["planetName"].Value);
                    }
                    else if (newMatch.Groups["attackType"].Value == "D")
                    {
                        destroyedPlanets.Add(newMatch.Groups["planetName"].Value);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

            if (attackedPlanets.Count > 0)
            {
                foreach (var planet in attackedPlanets.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");

            if (destroyedPlanets.Count > 0)
            {
                foreach (var planet in destroyedPlanets.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
        }

        static string Decrypt(string input)
        {
            int count = CountSpecailLetters(input);

            StringBuilder sb = new StringBuilder();

            if (count > 0)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    char toAdd = (char)(input[j] - count);
                    sb.Append(toAdd);
                }
            }

            return sb.ToString();
        }

        static int CountSpecailLetters(string input)
        {
            int count = 0;

            for (int k = 0; k < input.Length; k++)
            {
                if (char.IsLetter(input[k]))
                {
                    bool isTrue = input[k] == 's' || input[k] == 't' || input[k] == 'a' || input[k] == 'r'
                        || input[k] == 'S' || input[k] == 'T' || input[k] == 'A' || input[k] == 'R';

                    if (isTrue)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
