using System;
using System.Collections.Generic;
using System.Linq;

namespace Battle_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> personDict = new Dictionary<string, List<int>>();
            string input = string.Empty;
            while((input = Console.ReadLine()) != "Results")
            {
                var data = input
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
                var command = data[0];
                if (command == "Add") Add(personDict, data);
                else if (command == "Attack") Attack(personDict, data);
                else if (command == "Delete") Delete(personDict, data);
            }
            PrintResult(personDict);
        }
        static void Add(Dictionary<string, List<int>> personDict,string[] data)
        {
            var name = data[1];
            var health = int.Parse(data[2]);
            var energy = int.Parse(data[3]);
            if (!personDict.ContainsKey(name))
            {
                personDict.Add(name, new List<int>());
                personDict[name].Add(0);
                personDict[name].Add(0);
            }
            personDict[name][0] += health;
            personDict[name][1] += energy;
        }
        static void Attack(Dictionary<string, List<int>> personDict, string[] data)
        {
            var attackName = data[1];
            var defendName = data[2];
            var damage = int.Parse(data[3]);
            if(personDict.ContainsKey(attackName) && personDict.ContainsKey(defendName))
            {
                personDict[defendName][0] -= damage;
                personDict[attackName][1] -= 1;
                if(personDict[defendName][0] <= 0)
                {
                    Console.WriteLine($"{defendName} was disqualified!");
                    personDict.Remove(defendName);
                }
                if (personDict[attackName][1] <= 0)
                {
                    Console.WriteLine($"{attackName} was disqualified!");
                    personDict.Remove(attackName);
                }
            }
        }
        static void Delete(Dictionary<string, List<int>> personDict, string[] data)
        {
            var username = data[1];
            if(username == "All")
            {
                personDict.Clear();
            }
            else if (personDict.ContainsKey(username))
            {
                personDict.Remove(username);
            }
        }
        static void PrintResult(Dictionary<string, List<int>> personDict)
        {
            Console.WriteLine($"People count: {personDict.Count}");
            foreach (var person in personDict.OrderByDescending(x=>x.Value[0]).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{person.Key} - {person.Value[0]} - {person.Value[1]}");
            }
        }

    }
}
