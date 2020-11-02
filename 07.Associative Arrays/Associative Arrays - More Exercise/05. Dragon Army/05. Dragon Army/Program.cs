using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace _05._Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Dragon>> dragonDict = new Dictionary<string, List<Dragon>>();
            List<Dragon> dragonStats = new List<Dragon>();
            string pattern = @"^[A-Za-z]+\s[A-Za-z]+\s[\w]+\s[\w]+\s[\w]+";
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Match match = Regex.Match(Console.ReadLine(), pattern);
                string[] input = match.ToString()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (input.Length != 0)
                {
                    string typeOfDragon = input[0];
                    string nameOfDragon = input[1];
                    double damage = 45;
                    double health = 250;
                    double armor = 10;
                    if (input[2] != "null")
                    {
                        damage = double.Parse(input[2]);
                    }
                    if(input[3] != "null")
                    {
                        health = double.Parse(input[3]);
                    }
                    if(input[4] != "null")
                    {
                        armor = double.Parse(input[4]);
                    }
                    var dragon = new Dragon(nameOfDragon, damage, health, armor);
                    dragonStats.Add(dragon);
                    if (dragonDict.ContainsKey(typeOfDragon))
                    {
                        bool isMatch = true;
                        foreach (var data in dragonDict[typeOfDragon])
                        {
                            if(data.Name == nameOfDragon)
                            {
                                isMatch = false;
                                data.Damage = damage;
                                data.Health = health;
                                data.Armor = armor;
                                break;
                            }
                        }
                        if (isMatch)
                        {
                            dragonDict[typeOfDragon].Add(dragon);
                        }                    
                    }
                    else
                    {
                        dragonDict.Add(typeOfDragon, new List<Dragon>());
                        dragonDict[typeOfDragon].Add(dragon);
                    }    
                }
            }
            Console.WriteLine(ReturnResult(dragonDict));
        }
        static string ReturnResult(Dictionary<string, List<Dragon>> dragonDict)
        {
           
            StringBuilder result = new StringBuilder();
            foreach (var type in dragonDict)
            {
                result.AppendLine($"{type.Key}::({type.Value.Average(x=>x.Damage):f2}" +
                    $"/{type.Value.Average(x => x.Health):f2}" +
                    $"/{type.Value.Average(x=>x.Armor):f2})");
                foreach (var dragon in type.Value.OrderBy(x=>x.Name))
                {
                    result.AppendLine(string.Join(Environment.NewLine,dragon));
                }
            }
            return result.ToString().Trim();

        }
    }

    public class Dragon
    {
        public string Name { get; set; }
        public double Damage { get; set; }
        public double Health { get; set; }

        public double Armor { get; set; }
        public Dragon(string name, double damage,double health,double armor)
        {
            this.Name = name;
            this.Damage = damage;
            this.Health = health;
            this.Armor = armor;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"-{Name} -> damage: {Damage}, health: {Health}, armor: {Armor}");
            return result.ToString(); 
        }
    }
}
