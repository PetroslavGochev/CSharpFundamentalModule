using System;
using System.Collections.Generic;
using System.Linq;

namespace Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> account = new Dictionary<string, List<int>>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Log out")
            {
                var data = input
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);
                var command = data[0];
                if (command == "New follower") NewFollower(account, data);
                else if (command == "Like") Like(account, data);
                else if (command == "Comment") Comments(account, data);
                else if (command == "Blocked") Blocked(account, data);
            }
            PrintResult(account);
        }
        static void NewFollower(Dictionary<string, List<int>> account,string[] data)
        {
            string username = data[1];
            if (!account.ContainsKey(username))
            {
                account.Add(username, new List<int>());
                account[username].Add(0);
                account[username].Add(0); 
            }
        }
        static void Like(Dictionary<string, List<int>> account, string[] data)
        {
            var username = data[1];
            var count = int.Parse(data[2]);
            if (!account.ContainsKey(username))
            {
                account.Add(username, new List<int>());
                account[username].Add(count);
                account[username].Add(0);
            }
            else
            {
                account[username][0] += count;
            }
        }
        static void Comments(Dictionary<string, List<int>> account, string[] data)
        {
            var username = data[1];
            if (!account.ContainsKey(username))
            {
                account.Add(username, new List<int>());
                account[username].Add(0);
                account[username].Add(1);
            }
            else
            {
                account[username][1] += 1;
            }
        }
        static void Blocked(Dictionary<string, List<int>> account, string[] data)
        {
            var username = data[1];
            if (account.ContainsKey(username))
            {
                account.Remove(username);
            }
            else
            {
                Console.WriteLine($"{username} doesn`t exist.");
            }
        }
        static void PrintResult(Dictionary<string, List<int>> account)
        {
            Console.WriteLine($"{account.Count} followers");
            foreach (var username in account.OrderByDescending(x=>x.Value[0]).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{username.Key}: {username.Value.Sum()}");
            }
        }
    }
}
