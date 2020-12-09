using System;
using System.Collections.Generic;
using System.Linq;

namespace Hero_Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();
            string input = string.Empty;
            while((input = Console.ReadLine()) != "End")
            {
                var data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var command = data[0];
                var name = data[1];
                if(command == "Enroll")
                {
                    Enroll(heroes, name);
                }
                else if (command == "Learn")
                {
                    var spellName = data[2];
                    Learn(heroes, name, spellName);
                }
                else if (command == "Unlearn")
                {
                    var spellName = data[2];
                    UnLearn(heroes, name, spellName);
                }
            }
            PrintResult(heroes);
        }
        public static void Enroll(Dictionary<string, List<string>> heroes,string name)
        {
            if (heroes.ContainsKey(name))
            {
                Console.WriteLine($"{name} is already enrolled.");
            }
            else
            {
                heroes.Add(name, new List<string>());
            }
        }
        public static void Learn(Dictionary<string, List<string>> heroes, string name, string spellName)
        {
            if (!heroes.ContainsKey(name))
            {
                Console.WriteLine($"{name} doesn't exist.");
            }
            else if (heroes[name].Contains(spellName))
            {
                Console.WriteLine($"{name} has already learnt {spellName}.");
            }
            else
            {
                heroes[name].Add(spellName);
            }
            

        }
        public static void UnLearn(Dictionary<string, List<string>> heroes,string name,string spellName)
        {
            if (!heroes.ContainsKey(name))
            {
                Console.WriteLine($"{name} doesn't exist.");
            }
            else if (heroes[name].Contains(spellName))
            {
                heroes[name].Remove(spellName);
            }
            else
            {
                Console.WriteLine($"{name} doesn't know {spellName}.");
            }
        }
        public static void PrintResult(Dictionary<string, List<string>> heroes)
        {
            Console.WriteLine($"Heroes:");
            foreach (var item in heroes.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"== {item.Key}: {string.Join(", ", item.Value)}");
            }
        }
    }
}
