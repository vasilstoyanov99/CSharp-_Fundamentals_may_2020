using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Friendlist_Maintenance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> userNamesList = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = Console.ReadLine();
            short blacklistedCount = 0;
            short lostUserNamesCount = 0;

            while (input != "Report")
            {
                string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (data[0])
                {
                    case "Blacklist":
                        BlacklistUserName(userNamesList, data, ref blacklistedCount);
                        break;
                    case "Error":
                        Error(userNamesList, data, ref lostUserNamesCount);
                        break;
                    case "Change":
                        Change(userNamesList, data);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Blacklisted names: {blacklistedCount}");
            Console.WriteLine($"Lost names: {lostUserNamesCount}");
            Console.WriteLine(String.Join(" ", userNamesList));
        }

        static void BlacklistUserName(List<string> userNamesList, string[] data, ref short blacklistedCount)
        {
            string userName = data[1];

            if (userNamesList.Contains(userName))
            {
                int indexOfUserName = userNamesList.IndexOf(userName);
                userNamesList[indexOfUserName] = "Blacklisted";
                blacklistedCount++;
                Console.WriteLine($"{userName} was blacklisted.");
                return;
            }
            else
            {
                Console.WriteLine($"{userName} was not found.");
            }
        }

        static void Error(List<string> userNamesList, string[] data, ref short lostUserNamesCount)
        {
            int index = int.Parse(data[1]);
            bool isUserNameBlacklisted = userNamesList[index] == "Blacklisted";
            bool isUserNameLost = userNamesList[index] == "Lost";

            if (!isUserNameBlacklisted && !isUserNameLost)
            {
                string userName = userNamesList[index];
                userNamesList[index] = "Lost";
                lostUserNamesCount++;
                Console.WriteLine($"{userName} was lost due to an error.");
            }
        }

        static void Change(List<string> userNamesList, string[] data)
        {
            int index = int.Parse(data[1]);
            string newUserName = data[2];

            if (index >=0 && index <= userNamesList.Count - 1)
            {
                string oldUserName = userNamesList[index];
                userNamesList[index] = newUserName;
                Console.WriteLine($"{oldUserName} changed his username to {newUserName}.");
            }
        }
    }
}
