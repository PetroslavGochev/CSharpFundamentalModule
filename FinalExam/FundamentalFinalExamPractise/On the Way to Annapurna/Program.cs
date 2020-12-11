using System;
using System.Collections.Generic;
using System.Linq;

namespace On_the_Way_to_Annapurna
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> stores = new Dictionary<string, List<string>>();
            string input = string.Empty;
            while((input = Console.ReadLine()) != "END")
            {
                var data = input
                    .Split("->", StringSplitOptions.RemoveEmptyEntries);
                var command = data[0];
                if (command == "Add" && data[2].Contains(",")) AddList(stores, data);
                else if (command == "Add") Add(stores, data);
                else if (command == "Remove") Remove(stores, data);         
            }
            PrintResult(stores);
        }
        static void Add(Dictionary<string, List<string>> stores,string[] data)
        {
            var store = data[1];
            var item = data[2];          
            if (!stores.ContainsKey(store))
            {
                stores.Add(store, new List<string>());
            }
            stores[store].Add(item);         
        }
        static void AddList(Dictionary<string, List<string>> stores, string[] data)
        {
            var store = data[1];
            var listOfItem = data[2]
                .Split(",", StringSplitOptions.RemoveEmptyEntries);
            if (!stores.ContainsKey(store))
            {
                stores.Add(store, new List<string>());
            }
            foreach (var item in listOfItem)
            {
                stores[store].Add(item);
            }
        }
        static void Remove(Dictionary<string, List<string>> stores, string[] data)
        {
            var store = data[1];
            if (stores.ContainsKey(store))
            {
                stores.Remove(store);
            }
        }
        static void PrintResult(Dictionary<string, List<string>> stores)
        {
            Console.WriteLine($"Store list:");
            foreach (var item in stores.OrderByDescending(x=>x.Value.Count).ThenByDescending(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var it in item.Value)
                {
                    Console.WriteLine($"<<{it}>>");
                }
            }
        }
    }
}
