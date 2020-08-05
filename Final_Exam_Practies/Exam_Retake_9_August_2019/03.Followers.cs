using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<string, Follower> allFollowers = new SortedDictionary<string, Follower>();

            while (input != "Log out")
            {
                string[] commands = input.Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (commands[0])
                {
                    case "New follower":
                        AddNewFollower(allFollowers, commands[1]);
                        break;
                    case "Like":
                        AddLikesCount(allFollowers, commands);
                        break;
                    case "Comment":
                        AddOneComment(allFollowers, commands[1]);
                        break;
                    case "Blocked":
                        RemoveAFollower(allFollowers, commands[1]);
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (var follower in allFollowers.Values)
            {
                follower.SumCommentsAndLikes();
            }

            if (allFollowers.Count > 0)
            {
                Console.WriteLine($"{allFollowers.Count} followers");

                foreach (var follower in allFollowers.Values.OrderByDescending(x => x.Likes).ThenBy(x => x.Username))
                {
                    Console.WriteLine($"{follower.Username}: {follower.TotalLikesAndComments}");
                }
            }
        }

        static void AddNewFollower(SortedDictionary<string, Follower> allFollowers, string username)
        {
            if (!allFollowers.ContainsKey(username))
            {
                Follower newFollower = new Follower(username);
                allFollowers.Add(username, newFollower);
            }
        }

        static void AddLikesCount(SortedDictionary<string, Follower> allFollowers, string[] commands)
        {
            string username = commands[1];
            int count = int.Parse(commands[2]);

            if (!allFollowers.ContainsKey(username))
            {
                Follower newFollower = new Follower(username);
                newFollower.Likes += count;
                allFollowers.Add(username, newFollower);
            }
            else
            {
                allFollowers[username].Likes += count;
            }
        }

        static void AddOneComment(SortedDictionary<string, Follower> allFollowers, string username)
        {
            if (!allFollowers.ContainsKey(username))
            {
                Follower newFollower = new Follower(username);
                newFollower.Comments++;
                allFollowers.Add(username, newFollower);
            }
            else
            {
                allFollowers[username].Likes++;
            }
        }

        static void RemoveAFollower(SortedDictionary<string, Follower> allFollowers, string username)
        {
            if (allFollowers.ContainsKey(username))
            {
                allFollowers.Remove(username);
            }
            else
            {
                Console.WriteLine($"{username} doesn't exist.");
            }
        }
    }

    class Follower
    {
        public string Username { get; set; }
        public int Likes { get; set; }
        public int Comments { get; set; }
        public int TotalLikesAndComments { get; set; }

        public Follower(string username)
        {
            this.Username = username;
        }

        public void SumCommentsAndLikes()
        {
            TotalLikesAndComments = Likes + Comments;
        }
    }
}
