using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceUsers = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "Lumpawaroo")
            {
                string[] data = input.Split();

                if (data.Contains("|"))
                {
                    string forceSide = input.Split(" | ")[0];
                    string username = input.Split(" | ")[1];
                    AddUser(forceUsers, forceSide, username);
                }
                else
                {
                    ChangeForceSide(forceUsers, input);
                }

                input = Console.ReadLine();
            }

            foreach (var pair in forceUsers.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (pair.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {pair.Key}, Members: {pair.Value.Count}");

                    foreach (var usernames in pair.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {usernames}");
                    }
                }
            }
        }

        static void AddUser(Dictionary<string, List<string>> forceUsers, string forceSide, string username)
        {
          
            if (!forceUsers.ContainsKey(forceSide))
            {
                forceUsers.Add(forceSide, new List<string>());
                forceUsers[forceSide].Add(username);
            }
            else if (!forceUsers[forceSide].Contains(username))
            {
                forceUsers[forceSide].Add(username);
            }
        }

        static void ChangeForceSide(Dictionary<string, List<string>> forceUsers, string data)
        {
            string username = data.Split(" -> ")[0];
            string forceSide = data.Split(" -> ")[1];
            string userPreviousForceSide = String.Empty;
            bool isUserRegisted = false;

            foreach (var pair in forceUsers)
            {
                if (pair.Value.Contains(username))
                {
                    isUserRegisted = true;
                    userPreviousForceSide = pair.Key;
                    break;
                }
            }

            if (isUserRegisted)
            {
                forceUsers[userPreviousForceSide].Remove(username);
                forceUsers[forceSide].Add(username);
                Console.WriteLine($"{username} joins the {forceSide} side!");
            }
            else
            {
                AddUser(forceUsers, forceSide, username);
                Console.WriteLine($"{username} joins the {forceSide} side!");
            }
        }
    }
}
