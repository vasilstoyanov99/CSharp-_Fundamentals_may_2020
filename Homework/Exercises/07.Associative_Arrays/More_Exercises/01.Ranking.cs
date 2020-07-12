using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _01.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> allContestsData = new Dictionary<string, string>();
            List<UserData> allUsersData = new List<UserData>();
            string input = Console.ReadLine();

            while (input != "end of contests")
            {
                string contestName = input.Split(":")[0];
                string contestPassword = input.Split(":")[1];
                allContestsData.Add(contestName, contestPassword);
                input = Console.ReadLine();
            }

            string secondInput = Console.ReadLine();

            while (secondInput != "end of submissions")
            {
                string[] data = secondInput.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                CheckAndAddData(allContestsData, allUsersData, data);
                secondInput = Console.ReadLine();
            }

            string userWithMaxPoints = String.Empty;
            int maxPoints = 0;

            ReturnUserWithTotalMaxPoints(allUsersData, ref userWithMaxPoints, ref maxPoints);

            Console.WriteLine($"Best candidate is {userWithMaxPoints} with total {maxPoints} points.");
            Console.WriteLine("Ranking: ");

            foreach (var person in allUsersData.OrderBy(x => x.Username))
            {
                Console.WriteLine($"{person.Username}");

                foreach (var pair in person.contestAndPoints.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {pair.Key} -> {pair.Value}");
                }
            }


        }

        static void CheckAndAddData(Dictionary<string, string> allContestsData, List<UserData> allUsersData, string[] data)
        {
            string contestName = data[0];
            string contestPassword = data[1];
            string username = data[2];
            int points = int.Parse(data[3]);

            if (allContestsData.ContainsKey(contestName))
            {
                if (allContestsData[contestName] == contestPassword)
                {
                    int userNameFindIndex = allUsersData.FindIndex(x => x.Username == username);
                    if (userNameFindIndex >= 0)
                    {
                        if (username == allUsersData[userNameFindIndex].Username)
                        {
                            allUsersData[userNameFindIndex].AddNewContestData(contestName, points);
                        }
                    }

                    bool isTheSameContest = false;
                    UserData.CheckIf(allUsersData, username, contestName, ref isTheSameContest);

                    if (isTheSameContest)
                    {
                        userNameFindIndex = allUsersData.FindIndex(x => x.Username == username);
                        allUsersData[userNameFindIndex].ChangePoints(points, contestName);
                    }
                    else
                    {
                        UserData newUserData = new UserData(username, contestName, points);
                        allUsersData.Add(newUserData);
                    }
                }
            }
        }

        public static void ReturnUserWithTotalMaxPoints(List<UserData> allUsersData, ref string userWithMaxPoints, ref int maxPoints)
        {
            Dictionary<string, int> usersAndTheirTotalPoints = new Dictionary<string, int>();
            List<int> totalUsersPoints = new List<int>();

            foreach (var user in allUsersData)
            {
                int totalPoints = user.contestAndPoints.Values.Sum();
                usersAndTheirTotalPoints.Add(user.Username, totalPoints);
                totalUsersPoints.Add(totalPoints);
            }

            maxPoints = totalUsersPoints.Max();

            foreach (var pair in usersAndTheirTotalPoints)
            {
                if (pair.Value == maxPoints)
                {
                    userWithMaxPoints = pair.Key;
                    break;
                }
            }
        }

    }

    class UserData
    {
        public string Username { get; set; }

        public Dictionary<string, int> contestAndPoints = new Dictionary<string, int>();

        public UserData(string username, string contestName, int points)
        {
            this.Username = username;
            this.contestAndPoints.Add(contestName, points);
        }

        public void ChangePoints(int newPoints, string contestName)
        {
            if (this.contestAndPoints[contestName] < newPoints )
            {
                this.contestAndPoints[contestName] = newPoints;
            }
        }

        public void AddNewContestData(string contestName, int points)
        {
            if (!contestAndPoints.ContainsKey(contestName))
            {
                this.contestAndPoints.Add(contestName, points);
            }
        }

        public static void CheckIf(List<UserData> allUsersData, string usernameToChekc, string contestNameToChekc,
                                     ref bool isTheSameContest)
        {
            foreach (var item in allUsersData)
            {
                bool sameUsername = item.Username == usernameToChekc;
                bool sameContest = item.contestAndPoints.ContainsKey(contestNameToChekc);

                if (sameUsername && sameContest)
                {
                    isTheSameContest = true;
                    return;
                }
            }
        }
    }
}
