using System;
using System.Collections.Generic;
using System.Linq;

namespace Inbox_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> inbox = new Dictionary<string, List<string>>();
            string input = string.Empty;
            while((input = Console.ReadLine()) != "Statistics")
            {
                var data = input
                    .Split("->", StringSplitOptions.RemoveEmptyEntries);
                var command = data[0];
                var username = data[1];
                if (command == "Add") Add(inbox, username);
                else if (command == "Delete") Delete(inbox, username);
                else if(command == "Send")
                {
                    var email = data[2];
                    Send(inbox, username, email);
                }
            }
            PrintResult(inbox);
        }
        static void Add(Dictionary<string, List<string>> inbox,string username)
        {
            if (inbox.ContainsKey(username))
            {
                Console.WriteLine($"{username} is already registered");
            }
            else
            {
                inbox.Add(username, new List<string>());
            }
        }
        static void Send(Dictionary<string, List<string>> inbox, string username,string email)
        {
            if (inbox.ContainsKey(username))
            {
                inbox[username].Add(email);
            }
        }
        static void Delete(Dictionary<string, List<string>> inbox, string username)
        {
            if (inbox.ContainsKey(username))
            {
                inbox.Remove(username);
            }
            else
            {
                Console.WriteLine($"{username} not found!");
            }
        }
        static void PrintResult(Dictionary<string, List<string>> inbox)
        {
            Console.WriteLine($"Users count: {inbox.Count}");
            foreach (var item in inbox.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var message in item.Value)
                {
                    Console.WriteLine($"- {message}");
                }
            }
        }
    }
}
