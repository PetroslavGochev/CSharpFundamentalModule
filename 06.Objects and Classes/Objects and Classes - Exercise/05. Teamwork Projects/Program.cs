namespace _05._Teamwork_Projects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Team> teamList = new List<Team>();
            for (int i = 0; i < number; i++)
            {
                string[] teamCreate = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string nameOfTeam = teamCreate[1];
                string creatorName = teamCreate[0];
                if (teamList.Any(x => x.TeamName == nameOfTeam))
                {
                    Console.WriteLine($"Team {nameOfTeam} was already created!");
                }
                else if (teamList.Any(x => x.Creator == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                }
                else
                {
                    Team team = new Team(creatorName, nameOfTeam);
                    teamList.Add(team);
                    Console.WriteLine($"Team {nameOfTeam} has been created by {creatorName}!");
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] userJoin = command.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string nameOfTeam = userJoin[1];
                string userName = userJoin[0];
                if (!teamList.Any(x => x.TeamName == nameOfTeam))
                {
                    Console.WriteLine($"Team {nameOfTeam} does not exist!");
                }
                else if (teamList.Any(x => x.Creator.Contains(userName)) || teamList.Any(x => x.User.Contains(userName)))
                {
                    Console.WriteLine($"Member {userName} cannot join team {nameOfTeam}!");
                }
                else
                {
                    int index = teamList.FindIndex(a => a.TeamName == nameOfTeam);
                    teamList[index].User.Add(userName);
                }
            }

            List<Team> disbanded = teamList
                .FindAll(x => x.User.Count == 0)
                .OrderBy(x => x.TeamName)
                .ToList();
            List<Team> validTeams = teamList
                .FindAll(x => x.User.Count > 0)
                .OrderBy(x => x.TeamName)
                .ToList();
            if (validTeams.Count > 0)
            {
                Console.WriteLine(String.Join(Environment.NewLine, validTeams
                .OrderByDescending(x => x.User.Count)
                .ThenBy(x => x.TeamName)));
            }

            Console.WriteLine("Teams to disband:");

            foreach (Team team in disbanded)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }

    public class Team
    {
        public Team(string creator, string teamName)
        {
            this.Creator = creator;
            this.TeamName = teamName;
            this.User = new List<string>();
        }

        public string TeamName { get; set; }

        public string Creator { get; set; }

        public List<string> User { get; set; }
 
        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.Append($"{TeamName}");
            text.Append(Environment.NewLine);
            text.Append($"- " + Creator);
            text.Append(Environment.NewLine);
            foreach (string user in User.OrderBy(x => x))
            {
                text.Append($"-- " + user);
                text.Append(Environment.NewLine);
            }

            return text.ToString().TrimEnd();
        }
    }
}
