using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceSideDict = new Dictionary<string, List<string>>();
            ReceiveUsers(forceSideDict);
            forceSideDict = forceSideDict
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine(PrintDictionary(forceSideDict));
        }
        static Dictionary<string, List<string>> ReceiveUsers(Dictionary<string, List<string>> forceSideDict)
        {
            string command;
            while ((command = Console.ReadLine()) != "Lumpawaroo")
            {
                string[] receiveUser = new string[] { };
                if (command.Contains("|"))
                {
                    receiveUser = command
                     .Split(" | ", StringSplitOptions.RemoveEmptyEntries)
                     .ToArray();
                    string firstName = receiveUser[0];
                    string secondName = receiveUser[1];
                    AddUserInDictionary(forceSideDict, firstName, secondName);
                }
                else
                {
                    receiveUser = command
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                    string firstName = receiveUser[0];
                    string secondName = receiveUser[1];
                    AddOrChangeUserInDictionary(forceSideDict, firstName, secondName);
                }
            }
            return forceSideDict;
        }
        static Dictionary<string, List<string>> AddUserInDictionary(Dictionary<string, List<string>> forceSideDict, string firstName, string secondName)
        {
            foreach (var side in forceSideDict)
            {
                if (side.Value.Contains(secondName))
                {
                    return forceSideDict;
                }
            }
            if (forceSideDict.ContainsKey(firstName))
            {
                if (forceSideDict[firstName].Contains(secondName))
                {
                    return forceSideDict;
                }
                forceSideDict[firstName].Add(secondName);
            }
            else
            {
                forceSideDict.Add(firstName, new List<string>());
                forceSideDict[firstName].Add(secondName);
            }
            return forceSideDict;
        }
        static Dictionary<string, List<string>> AddOrChangeUserInDictionary(Dictionary<string, List<string>> forceSideDict, string firstName, string secondName)
        {
            foreach (var side in forceSideDict)
            {
                if (side.Value.Contains(firstName))
                {
                    side.Value.Remove(firstName);
                    break;
                }
            }
            if (forceSideDict.ContainsKey(secondName))
            {
                forceSideDict[secondName].Add(firstName);
            }
            else
            {
                forceSideDict.Add(secondName, new List<string>());
                forceSideDict[secondName].Add(firstName);
            }
            Console.WriteLine($"{firstName} joins the {secondName} side!");
            return forceSideDict;
        }
        static string PrintDictionary(Dictionary<string, List<string>> forceDict)
        {
            StringBuilder text = new StringBuilder();
            foreach (var side in forceDict)
            {
                if (side.Value.Count == 0)
                {
                    continue;
                }
                text.AppendLine($"Side: {side.Key}, Members: {side.Value.Count}");
                foreach (var user in side.Value.OrderBy(x => x).ToList())
                {
                    text.AppendLine($"! {user}");
                }
            }
            return text.ToString();
        }
    }
}
