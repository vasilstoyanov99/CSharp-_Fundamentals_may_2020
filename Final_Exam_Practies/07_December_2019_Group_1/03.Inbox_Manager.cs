using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace _03.Inbox_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, User> allUsers = new Dictionary<string, User>();

            while (input != "Statistics")
            {
                string[] commands = input.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (commands[0])
                {
                    case "Add":
                        AddNewUser(allUsers, commands);
                        break;
                    case "Send":
                        SendAnEmail(allUsers, commands);
                        break;
                    case "Delete":
                        DeleteUser(allUsers, commands);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {allUsers.Count}");

            foreach (var user in allUsers.Values.OrderByDescending(x => x.SendEmails.Count).ThenBy(x => x.Username))
            {
                Console.WriteLine(user.Username);

                foreach (var email in user.SendEmails)
                {
                    Console.WriteLine($"- {email}");
                }
            }
        }

        static void AddNewUser(Dictionary<string, User> allUsers, string[] commands)
        {
            string userToAdd = commands[1];

            if (allUsers.ContainsKey(userToAdd))
            {
                Console.WriteLine($"{userToAdd} is already registered");
            }
            else
            {
                User newUser = new User(userToAdd);
                allUsers.Add(userToAdd, newUser);
            }
        }

        static void SendAnEmail(Dictionary<string, User> allUsers, string[] commands)
        {
            string username = commands[1];
            string email = commands[2];

            allUsers[username].SendEmails.Add(email);
        }

        static void DeleteUser(Dictionary<string, User> allUsers, string[] commands)
        {
            string username = commands[1];

            if (allUsers.ContainsKey(username))
            {
                allUsers.Remove(username);
            }
            else
            {
                Console.WriteLine($"{username} not found!");
            }
        }
    }

    class User
    {
        public string Username { get; set; }
        public List<string> SendEmails { get; set; }

        public User(string username)
        {
            this.Username = username;
            SendEmails = new List<string>();
        }      
    }
}
