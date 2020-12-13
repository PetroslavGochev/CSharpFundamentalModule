using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guest = new Dictionary<string, List<string>>();
            Dictionary<string, int> unliked = new Dictionary<string, int>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Stop")
            {
                var data = input
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);
                var command = data[0];
                var guestName = data[1];
                var meal = data[2];
                if (command == "Like")
                {
                    if (!guest.ContainsKey(guestName))
                    {
                        guest.Add(guestName, new List<string>());
                        guest[guestName].Add(meal);
                        unliked.Add(guestName, 0);
                    }
                    else
                    {
                        if (!guest[guestName].Contains(meal))
                        {
                            guest[guestName].Add(meal);
                        }
                    }
                }
                else if (command == "Unlike")
                {
                    if (unliked.ContainsKey(guestName) && guest[guestName].Contains(meal))
                    {
                        Console.WriteLine($"{guestName} doesn't like the {meal}.");
                        guest[guestName].Remove(meal);
                        unliked[guestName]++;
                    }
                    else if (!unliked.ContainsKey(guestName))
                    {
                        Console.WriteLine($"{guestName} is not at the party.");
                    }
                    else if (!guest[guestName].Contains(meal))
                    {
                        Console.WriteLine($"{guestName} doesn't have the {meal} in his/her collection.");
                    }
                }
            }
            foreach (var item in guest.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
            }
            int totalSum = unliked.Values.Sum();
            Console.WriteLine($"Unliked meals: {totalSum}");
        }
    }
}

