using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());
            List<Team> allTeams = new List<Team>();

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] data = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string creator = data[0];
                string teamName = data[1];
                bool isTeamNameInTheList = allTeams.Any(x => x.Name == teamName);

                if (isTeamNameInTheList)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                bool isCreatorAlreadyExistsInTheList = allTeams.Any(x => x.Creator == creator);

                if (isCreatorAlreadyExistsInTheList)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team newTeam = new Team(creator, teamName);
                allTeams.Add(newTeam);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] userData = input.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string userName = userData[0];
                string teamName = userData[1];
                bool doesTeamNameExistInTheList = allTeams.Any(x => x.Name == teamName);

                if (!doesTeamNameExistInTheList)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                bool doesUserExistInOtherTeam = allTeams.Any(x => x.Creator == userName);

                if (doesUserExistInOtherTeam)
                {
                    Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                    continue;
                }

                int teamIndex = allTeams.FindIndex(x => x.Name == teamName);
                allTeams[teamIndex].AddMember(userName);
            }

            foreach (var currTeam in allTeams.OrderByDescending(x => x.members.Count).ThenBy(x => x.Name).Where(x => x.members.Count > 0))
            {
                Console.WriteLine($"{currTeam.Name}");
                Console.WriteLine($"- {currTeam.Creator}");

                for (int i = 0; i < currTeam.members.Count; i++)
                {
                    Console.WriteLine($"-- {currTeam.members[i]}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var currTeam in allTeams.OrderBy(x => x.Name).Where(x => x.members.Count == 0))
            {
                Console.WriteLine($"{currTeam.Name}");
            }
        }

        class Team
        {
            public string Creator { set; get; }
            public string Name { set; get; }

            public List<string> members = new List<string>();

            public Team(string creator, string name)
            {
                this.Creator = creator;
                this.Name = name;
            }
            public void AddMember(string userToAdd)
            {
                this.members.Add(userToAdd);
            }

        }
    }
}
