using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_sessions
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> roads = new Dictionary<string, List<string>>();
            string input = string.Empty;
            while((input = Console.ReadLine()) != "END")
            {
                var data = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
                var command = data[0];
                if (command == "Add") Add(roads, data);
                else if (command == "Move") Move(roads, data);
                else if (command == "Close") Close(roads, data);
            }
            PrintResult(roads);
        }
        public static void Add(Dictionary<string, List<string>> roads,string[] data)
        {
            var road = data[1];
            var racer = data[2];
            if (!roads.ContainsKey(road))
            {
                roads.Add(road, new List<string>());
            }
            roads[road].Add(racer);
        }
        public static void Move(Dictionary<string, List<string>> roads,string[] data)
        {
            var currentRoad = data[1];
            var racer = data[2];
            var nextRoad = data[3];
            if (roads[currentRoad].Contains(racer))
            {
                roads[currentRoad].Remove(racer);
                roads[nextRoad].Add(racer);
            }
        }
        public static void Close(Dictionary<string, List<string>> roads,string[]data)
        {
            var road = data[1];
            roads.Remove(road);
        }
        public static void PrintResult(Dictionary<string, List<string>> roads)
        {
            foreach (var road in roads.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{road.Key}");
                foreach (var racer in road.Value)
                {
                    Console.WriteLine($"++{racer}");
                }
            }
        }
    }
}
