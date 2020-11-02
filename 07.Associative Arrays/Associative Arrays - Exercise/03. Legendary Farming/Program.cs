using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            ReceiveKeyMaterials();
        }

        static void ReceiveKeyMaterials()
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();
            SortedDictionary<string, int> junks = new SortedDictionary<string, int>();
            materials.Add("fragments", 0);
            materials.Add("shards", 0);
            materials.Add("motes", 0);
            while (true)
            {
                string[] material = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.ToLowerInvariant())
                    .ToArray();

                for (int i = 0; i < material.Length; i += 2)
                {
                    string product = material[i + 1];
                    int quantity = int.Parse(material[i]);
                    if (product == "fragments" || product == "shards" || product == "motes")
                    {
                        if (materials.ContainsKey(product))
                        {
                            materials[product] += quantity;
                        }
                    }
                    else
                    {
                        if (junks.ContainsKey(product))
                        {
                            junks[product] += quantity;
                        }
                        else
                        {
                            junks.Add(product, quantity);
                        }
                    }
                    string legendaryItem = ReturnLegendaryItem(materials);
                    if (legendaryItem != "")
                    {
                        materials[legendaryItem] -= 250;
                        legendaryItem = legendaryItem == "fragments" ? "Valanyr" : legendaryItem == "shards" ? "Shadowmourne" : "Dragonwrath";
                        Console.WriteLine($"{legendaryItem} obtained!");
                        PrintResult(materials, junks);
                        return;
                    }
                }
            }
        }
        static string ReturnLegendaryItem(Dictionary<string, int> dictOfMaterials)
        {
            foreach (var item in dictOfMaterials)
            {
                if (dictOfMaterials[item.Key] >= 250)
                {
                    return item.Key;

                }
            }
            return "";
        }
        static void PrintResult(Dictionary<string, int> materials, SortedDictionary<string, int> junks)
        {
            var orderList = materials.OrderByDescending(x => x.Value)
                 .ThenBy(x => x.Key);

            foreach (var item in orderList)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junks)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
