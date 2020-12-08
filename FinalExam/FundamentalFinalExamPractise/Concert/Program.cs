using System;
using System.Collections.Generic;
using System.Linq;

namespace Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
            string input = string.Empty;
            while((input = Console.ReadLine()) != "start of concert")
            {
                string[] data = input
                    .Split("; ", StringSplitOptions.RemoveEmptyEntries);
                string command = data[0];
                if(command == "Add")
                {
                    Add(groups, data);
                }
                else if (command == "Play")
                {
                    Play(groups, data);
                }
            }
            string bandNamePrint = Console.ReadLine();
            PrintAllBand(groups);
            PrintBand(groups, bandNamePrint);
        }
        public static void Add(Dictionary<string, List<string>> groups,string[] data)
        {
            string bandName = data[1];
            List<string> listOfMembers = data[2].Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            if (!groups.ContainsKey(bandName))
            {
                groups.Add(bandName, new List<string>());
                groups[bandName].Add("0");
            }
            foreach (var member in listOfMembers)
            {
                if (groups[bandName].Contains(member))
                {
                    continue;
                }
                groups[bandName].Add(member);
            }
        }
        public static void Play(Dictionary<string, List<string>> groups, string[] data)
        {
            string bandName = data[1];
            int time = int.Parse(data[2]);
            if (!groups.ContainsKey(bandName))
            {
                groups.Add(bandName, new List<string>());
                groups[bandName].Add("0");
            }
            string addTime = (int.Parse(groups[bandName][0]) + time).ToString();
            groups[bandName][0] = addTime;
        }
        public static void PrintAllBand(Dictionary<string, List<string>> groups)
        {
            int totalTime = 0;
            foreach (var item in groups)
            {
                totalTime += int.Parse(item.Value[0]);
            }
            Console.WriteLine($"Total time: {totalTime}");
            foreach (var band in groups.OrderByDescending(x=>int.Parse(x.Value[0])).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value[0]}");
            }
        }
        public static void PrintBand(Dictionary<string, List<string>> groups,string bandName)
        {
            Console.WriteLine($"{bandName}");
            for (int i = 0; i < groups[bandName].Count; i++)
            {
                if (i == 0) continue;
                Console.WriteLine($"=> {groups[bandName][i]}");
            }
        }
    }
}
