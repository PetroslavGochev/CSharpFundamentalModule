using System;
using System.Collections.Generic;
using System.Linq;

namespace Messages_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> manager = new Dictionary<string, List<int>>();
            int capacity = int.Parse(Console.ReadLine());
            string input = string.Empty;
            while((input = Console.ReadLine()) != "Statistics")
            {
                var data = input.Split("=", StringSplitOptions.RemoveEmptyEntries);
                var command = data[0];
                if (command == "Add") Add(manager, data, capacity);
                else if (command == "Message") Message(manager, data, capacity);
                else if (command == "Empty") Empty(manager, data);
            }
            PrintResult(manager);
        }
        static void Add(Dictionary<string, List<int>> manager,string[] data,int capacity)
        {
            var username = data[1];
            var sent = int.Parse(data[2]);
            var receive = int.Parse(data[3]);
            if (sent + receive < capacity && !manager.ContainsKey(username))
            {
                manager.Add(username, new List<int>());
                manager[username].Add(sent);
                manager[username].Add(receive);
            }         
        }
        static void Message(Dictionary<string, List<int>> manager, string[] data,int capacity)
        {
            var sender = data[1];
            var receiver = data[2];
            if(manager.ContainsKey(sender) && manager.ContainsKey(receiver))
            {
                manager[sender][0]++;
                manager[receiver][1]++;
                if(manager[sender].Sum() >= capacity)
                {
                    manager.Remove(sender);
                    Console.WriteLine($"{sender} reached the capacity!");
                }
                if (manager[receiver].Sum() >= capacity)
                {
                    manager.Remove(receiver);
                    Console.WriteLine($"{receiver} reached the capacity!");
                }
            }
        }
        static void Empty(Dictionary<string, List<int>> manager, string[] data)
        {
            var username = data[1];
            if(username == "All")
            {
                manager.Clear();
            }
            else if (manager.ContainsKey(username))
            {
                manager.Remove(username);
            }
        }
        static void PrintResult(Dictionary<string, List<int>> manager)
        {
            Console.WriteLine($"Users count: {manager.Count}");
            foreach (var user in manager.OrderByDescending(x=>x.Value[1]).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{user.Key} - {user.Value.Sum()}");
            }
        }
    }
}
