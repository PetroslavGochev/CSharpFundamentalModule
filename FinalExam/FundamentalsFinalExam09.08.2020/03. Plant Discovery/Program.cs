using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> result = new Dictionary<string, List<double>>();
            Dictionary<string, List<double>> dict = new Dictionary<string, List<double>>();
            string[] splitter = new string[]
            {
                ": ",
                " - "
            };
            int number = int.Parse(Console.ReadLine());
            string input = string.Empty;
            for (int i = 1; i <= number; i++)
            {
                input = Console.ReadLine();
                var data = input
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var name = data[0];
                var rarity = double.Parse(data[1]);
                if (!result.ContainsKey(name))
                {
                    result.Add(name, new List<double>());
                    result[name].Add(0);
                    result[name].Add(0);
                }
                result[name][0] = rarity;
            }
            while ((input = Console.ReadLine()) != "Exhibition")
            {
                var data = input
                    .Split(splitter, StringSplitOptions.RemoveEmptyEntries);
                var command = data[0];
                var name = data[1];

                if (data[0] == "Rate")
                {
                    var rating = double.Parse(data[2]);
                    if (result.ContainsKey(name))
                    {
                        if (dict.ContainsKey(name))
                        {
                            dict[name].Add(rating);
                            continue;
                        }
                        dict.Add(name, new List<double>());
                        dict[name].Add(rating);
                        continue;
                    }
                }
                else if (data[0] == "Update")
                {
                    var rarity = int.Parse(data[2]);
                    if (result.ContainsKey(name))
                    {
                        result[name][0] = rarity;
                        continue;
                    }
                }
                else if (data[0] == "Reset")
                {
                    if (result.ContainsKey(name))
                    {
                        dict[name].Clear();
                        continue;
                    }
                }
                Console.WriteLine("error");
            }
            foreach (var item in dict)
            {
                if(item.Value.Count != 0)
                {
                    result[item.Key][1] = item.Value.Average();
                }           
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in result.OrderByDescending(x => x.Value[0]).ThenByDescending(x => x.Value[1])) 
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value[0]}; Rating: {item.Value[1]:f2}");
            }
        }
    }
}
