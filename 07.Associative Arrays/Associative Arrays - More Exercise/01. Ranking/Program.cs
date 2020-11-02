using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contest = new Dictionary<string, string>();
            SortedDictionary<string,Dictionary<string,int>> submissions = new SortedDictionary<string, Dictionary<string, int>>();
            string command = string.Empty;
            ReceiveContest(contest, command);
            ReceiveSubmissions(submissions, contest, command);
            PrintBestResult(submissions);
            Console.WriteLine(PrintAllMembers(submissions));

            
        }
        static void ReceiveContest(Dictionary<string,string> contest,string command)
        {
            while((command = Console.ReadLine())!= "end of contests")
            {
                string[] input = command
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                contest.Add(input[0], input[1]);
            }
        }
        static void ReceiveSubmissions(SortedDictionary<string, Dictionary<string, int>> submissions, Dictionary<string, string> contest,string command)
        {
            while((command = Console.ReadLine())!= "end of submissions")
            {
                string[] input = command
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if(contest.ContainsKey(input[0]) && contest[input[0]] == input[1])
                {
                    if (submissions.ContainsKey(input[2]))
                    {
                        if (submissions[input[2]].ContainsKey(input[0]))
                        {
                            if(submissions[input[2]][input[0]] < int.Parse(input[3]))
                            {
                                submissions[input[2]][input[0]] = int.Parse(input[3]);
                            }
                        }
                        else
                        {
                            submissions[input[2]].Add(input[0], int.Parse(input[3]));
                        }
                    }
                    else
                    {
                        submissions.Add(input[2], new Dictionary<string, int>());
                        submissions[input[2]].Add(input[0], int.Parse(input[3]));
                    }
                }
            }
        }
        static void PrintBestResult(SortedDictionary<string, Dictionary<string, int>> submissions)
        {         
            int bestPoint = 0;
            string bestName = string.Empty;
            foreach (var name in submissions)
            {
                int point = 0;
                foreach (var namePoint in name.Value.Values)
                {
                    point += namePoint;
                    
                }
                if(point > bestPoint)
                {
                    bestPoint = point;
                    bestName = name.Key;
                }
            }
            Console.WriteLine($"Best candidate is {bestName} with total {bestPoint} points.");
        }
        static string PrintAllMembers(SortedDictionary<string, Dictionary<string, int>> submissions)
        {
            
            StringBuilder result = new StringBuilder();
            result.AppendLine("Ranking:");
            foreach (var name in submissions)
            {
                result.AppendLine(name.Key);
                foreach (var nameSub in name.Value.OrderByDescending(x=>x.Value).ToDictionary(x=>x.Key,y=>y.Value))
                {
                    result.AppendLine($"#  {nameSub.Key} -> {nameSub.Value}");
                }
            }
            return result.ToString().Trim();
        }
    }
}
