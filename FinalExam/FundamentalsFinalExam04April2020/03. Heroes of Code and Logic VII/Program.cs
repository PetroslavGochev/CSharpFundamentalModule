using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<int>> heroes = new SortedDictionary<string, List<int>>();
            int number = int.Parse(Console.ReadLine());
            string input = string.Empty;
            for (int i = 1; i <= number; i++)
            {
                var data = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                FillDictionary(heroes, data);
            }
            while((input = Console.ReadLine()) != "End")
            {
                var data = input
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                var command = data[0];
                if (command == "CastSpell") CastSpell(heroes, data);
                else if (command == "TakeDamage") TakeDamage(heroes, data);
                else if (command == "Recharge") Recharge(heroes, data);
                else if (command == "Heal") Heal(heroes, data);
            }
            Console.WriteLine(PrintResult(heroes));
        }
        static void FillDictionary(SortedDictionary<string,List<int>> heroes,string[] data)
        {
            var heroName = data[0];
            var hp = int.Parse(data[1]);
            var mp = int.Parse(data[2]);
            heroes.Add(heroName, new List<int>() { hp, mp });
            if(heroes[heroName][0] > 100) heroes[heroName][0] = 100;
            if(heroes[heroName][1] > 200) heroes[heroName][1] = 200;
            
        }
        static void CastSpell(SortedDictionary<string, List<int>> heroes,string[] data)
        {
            var heroName = data[1];
            var mp = int.Parse(data[2]);
            var spell = data[3];
            if(mp <= heroes[heroName][1])
            {
                heroes[heroName][1] -= mp;
                Console.WriteLine($"{heroName} has successfully cast {spell} and now has {heroes[heroName][1]} MP!");
            }
            else
            {
                Console.WriteLine($"{heroName} does not have enough MP to cast {spell}!");
            }
        }
        static void TakeDamage(SortedDictionary<string, List<int>> heroes, string[] data)
        {
            var heroName = data[1];
            var hp = int.Parse(data[2]);
            var attacker = data[3];
            heroes[heroName][0] -= hp;
            if(heroes[heroName][0] > 0)
            {
                Console.WriteLine($"{heroName} was hit for {hp} HP by {attacker} and now has {heroes[heroName][0]} HP left!");
            }
            else
            {
                Console.WriteLine($"{heroName} has been killed by {attacker}!");
                heroes.Remove(heroName);
            }
        }
        static void Recharge(SortedDictionary<string, List<int>> heroes, string[] data)
        {
            var heroName = data[1];
            var mp = int.Parse(data[2]);
            if(heroes[heroName][1] + mp > 200)
            {
                Console.WriteLine($"{heroName} recharged for {200 - heroes[heroName][1]} MP!");
                heroes[heroName][1] = 200;             
            }
            else
            {
                heroes[heroName][1] += mp;
                Console.WriteLine($"{heroName} recharged for {mp} MP!");
            }
            
        }
        static void Heal(SortedDictionary<string, List<int>> heroes, string[] data)
        {
            var heroName = data[1];
            var hp = int.Parse(data[2]);
            if (heroes[heroName][0] + hp > 100)
            {
                Console.WriteLine($"{heroName} healed for {100 - heroes[heroName][0]} HP!");
                heroes[heroName][0] = 100;
                
            }
            else
            {
                heroes[heroName][0] += hp;
                Console.WriteLine($"{heroName} healed for {hp} HP!");
            }
            
        }
        static string PrintResult(SortedDictionary<string, List<int>> heroes)
        {
            StringBuilder result = new StringBuilder();
            foreach (var hero in heroes.OrderByDescending(x=>x.Value[0]))
            {
                result.AppendLine($"{hero.Key}");
                result.AppendLine($"HP: {hero.Value[0]}");
                result.AppendLine($"MP: {hero.Value[1]}");
            }
            return result.ToString().Trim();
        }
    }
}
