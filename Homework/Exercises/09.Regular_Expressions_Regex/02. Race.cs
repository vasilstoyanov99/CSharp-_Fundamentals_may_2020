using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();
            Dictionary<string, int> allParticipantsData = new Dictionary<string, int>();

            while (input != "end of race")
            {
                Regex splitBy = new Regex(@"(\w)");
                string[] splitted = splitBy.Split(input);
                StringBuilder sbName = new StringBuilder();
                int distanceRan = 0;
                splitted = splitted.Where(x => x != "").ToArray();

                for (int i = 0; i < splitted.Length; i++)
                {
                    if (char.IsLetter(splitted[i][0]))
                    {
                        sbName.Append(splitted[i][0]);
                    }
                    else if (char.IsDigit(splitted[i][0]))
                    {
                        distanceRan += int.Parse(splitted[i]);
                    }
                }

                string name = sbName.ToString();

                if (participants.Contains(name))
                {
                    if (allParticipantsData.ContainsKey(name))
                    {
                        allParticipantsData[name] += distanceRan;
                    }
                    else
                    {
                        allParticipantsData.Add(name, distanceRan);
                    }
                }

                input = Console.ReadLine();
            }

            Dictionary<string, int> topThree = allParticipantsData.OrderByDescending(x => x.Value).Take(3)
                .ToDictionary(a => a.Key, b => b.Value);
            List<string> names = new List<string>();

            foreach (var pair in topThree)
            {
                names.Add(pair.Key);
            }

            Console.WriteLine($"1st place: {names[0]}");
            Console.WriteLine($"2nd place: {names[1]}");
            Console.WriteLine($"3rd place: {names[2]}");
        }
    }
}
