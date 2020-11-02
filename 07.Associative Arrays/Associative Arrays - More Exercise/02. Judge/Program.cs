using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> judge = new Dictionary<string, Dictionary<string, int>>();
            string command = string.Empty;
            while((command = Console.ReadLine())!= "no more time")
            {
                string[] input = command
                    .Split(" -> ")
                    .ToArray();
                string subject = input[1];
                string name = input[0];
                int points = int.Parse(input[2]);
                if (judge.ContainsKey(subject))
                {
                    if (judge[subject].ContainsKey(name))
                    {
                        if (judge[subject][name] < points)
                        {
                            judge[subject][name] = points;
                        }
                    }
                    else
                    {
                        judge[subject].Add(name, points);
                    }
                }
                else
                {
                    judge.Add(subject, new Dictionary<string, int>());
                    judge[subject].Add(name, points);
                }
            }
            Dictionary<string, int> individual = new Dictionary<string, int>();
            foreach (var item in judge)
            {
                foreach (var name in item.Value)
                {
                    if (individual.ContainsKey(name.Key))
                    {
                        individual[name.Key] += name.Value;
                    }
                    else
                    {
                        individual.Add(name.Key, name.Value);
                    }
                    
                }
            }
            Console.WriteLine(PrintResult(judge,individual));
        }
        static string PrintResult(Dictionary<string, Dictionary<string, int>> judge, Dictionary<string, int> individual)
        {
            StringBuilder result = new StringBuilder();
            foreach (var subject in judge)
            {
                
                result.AppendLine($"{subject.Key}: {subject.Value.Count} participants");
                int counter = 0;
                foreach (var name in subject.Value.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key).ToDictionary(x=>x.Key,y=>y.Value))
                {
                    counter++;
                    result.AppendLine($"{counter}. {name.Key} <::> {name.Value}");
                }
            }
            result.AppendLine($"Individual standings:");
            int count = 0;
            foreach (var item in individual.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key).ToDictionary(x=>x.Key, y=>y.Value))
            {
                count++;
                result.AppendLine($"{count}. {item.Key} -> {item.Value}");
            }
            return result.ToString().Trim();
        }
    }
}
