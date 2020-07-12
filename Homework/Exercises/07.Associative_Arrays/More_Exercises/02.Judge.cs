using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<UserData>> contestsData = new Dictionary<string, List<UserData>>();
            Dictionary<string, int> participantsTotalPoints = new Dictionary<string, int>();
            string input = Console.ReadLine();

            while (input != "no more time")
            {
                string[] data = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                AddData(contestsData, data);
                input = Console.ReadLine();
            }

            int position = 1;

            foreach (var contest in contestsData)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");

                foreach (var participant in contest.Value.OrderByDescending(x => x.Points).ThenBy(x => x.Username))
                {
                    Console.WriteLine($"{position}. {participant.Username} <::> {participant.Points}");
                    position++;
                }

                position = 1;
            }

            foreach (var pair in contestsData)
            {
                foreach (var currContestParticipant in pair.Value)
                {
                    currContestParticipant.AddPoints(participantsTotalPoints);
                }
            }

            position = 1;
            Console.WriteLine("Individual standings:");

            foreach (var pair in participantsTotalPoints.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{position}. {pair.Key} -> {pair.Value}");
                position++;
            }
        }

        static void AddData(Dictionary<string, List<UserData>> contestsData, string[] data)
        {
            string username = data[0];
            string contestName = data[1];
            int points = int.Parse(data[2]);

            if (!contestsData.ContainsKey(contestName))
            {
                contestsData.Add(contestName, new List<UserData>());
                UserData newUserData = new UserData(username, points);
                contestsData[contestName].Add(newUserData);

            }
            else
            {
                if (contestsData[contestName].FirstOrDefault(x => x.Username == username) != null)
                {
                    ChangePoints(contestsData, username, contestName, points);
                }
                else
                {
                    UserData newUserData = new UserData(username, points);
                    contestsData[contestName].Add(newUserData);
                }
            }
        }


        static void ChangePoints(Dictionary<string, List<UserData>> contestsData, string username, string contestName, int points)
        {
            foreach (var user in contestsData[contestName])
            {
                if (user.Username == username)
                {
                    if (user.Points < points)
                    {
                        user.Points = points;
                    }
                }
            }
        }
    }

    class UserData
    {
        public string Username { get; set; }
        public int Points { get; set; }

        public UserData(string username, int points)
        {
            this.Username = username;
            this.Points = points;
        }

        public void AddPoints(Dictionary<string, int> participantsTotalPoints)
        {
            if (!participantsTotalPoints.ContainsKey(Username))
            {
                participantsTotalPoints.Add(Username, Points);
            }
            else
            {
                participantsTotalPoints[Username] += Points;
            }
        }

    }
}
