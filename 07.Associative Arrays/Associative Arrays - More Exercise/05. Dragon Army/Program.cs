using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Dragon>> dragonDict = new Dictionary<string, List<Dragon>>();
            List<Dragon> dragonStats = new List<Dragon>();
            string pattern = @"[A-Z][a-z]*\s[A-Z][a-z]*\s[0-9]*\s[0-9]*\s[0-9]*";
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Match match = Regex.Match(Console.ReadLine(), pattern);
                string[] input = match.ToString()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if(input.Length != 0)
                {
                    string typeOfDragon = input[0];
                    string nameOfDragon = input[1];
                    string damage = input[2];
                    string health = input[3];
                    string armor = input[2];
                }  
            }
        }
    }

    public class Dragon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Healt { get; set; }

        public int Armor { get; set; }
    }
}
