using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();
            string input = string.Empty;
            while((input = Console.ReadLine()) != "Sail")
            {
                var data = input
                    .Split("||", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                FilledDictionary(cities, data);
            }
            while((input = Console.ReadLine()) != "End")
            {
                var data = input
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var command = data[0];
                data = data.Skip(1).ToArray();
                if(command == "Plunder")
                {
                    Plunder(cities, data);
                }
                else if (command == "Prosper")
                {
                    if (int.Parse(data[1]) < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                        continue;
                    }
                    Prosper(cities, data);
                }
            }
            Console.WriteLine(Result(cities));
        }
        static void FilledDictionary(Dictionary<string,List<int>> cities,string[] data)
        {
            var city = data[0];
            var population = int.Parse(data[1]);
            var gold = int.Parse(data[2]);
            if (!cities.ContainsKey(city))
            {
                cities.Add(city, new List<int>());
                cities[city].Add(0);
                cities[city].Add(0);
            }
            cities[city][0] += population;
            cities[city][1] += gold;
        }
        static void Plunder(Dictionary<string,List<int>> cities,string[]data)
        {
            var city = data[0];
            var kill = int.Parse(data[1]);
            var gold = int.Parse(data[2]);
            if (cities.ContainsKey(city))
            {
                Console.WriteLine($"{city} plundered! {gold} gold stolen, {kill} citizens killed.");
                cities[city][0] -= kill;
                cities[city][1] -= gold;
                if(cities[city][0] <= 0  || cities[city][1] <= 0)
                {
                    Console.WriteLine($"{city} has been wiped off the map!");
                    cities.Remove(city);
                }
            }
        }
        static void Prosper(Dictionary<string, List<int>> cities, string[] data)
        {
            var city = data[0];
            var gold = int.Parse(data[1]);
            if (cities.ContainsKey(city))
            {
                cities[city][1] += gold;
                Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {cities[city][1]} gold.");             
            }
        }
        static string Result(Dictionary<string,List<int>> cities)
        {
            StringBuilder result = new StringBuilder();
            if(cities.Count == 0)
            {
                result.Append($"Ahoy, Captain! All targets have been plundered and destroyed!");
                return result.ToString();
            }
            result.AppendLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
            foreach (var city in cities.OrderByDescending(x=>x.Value[1])
                                       .ThenBy(x=>x.Key)
                                       .ToDictionary(x=>x.Key,y=>y.Value))
            {
                result.AppendLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
            }
            return result.ToString().Trim();
        }
    }
}
