using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Craft!")
            {
                var command = input
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                if(command[0] == "Collect")
                {
                    if (!inventory.Contains(command[1]))
                    {
                        inventory.Add(command[1]);
                    }
                }
                else if(command[0] == "Drop")
                {
                    if (inventory.Contains(command[1]))
                    {
                        inventory.Remove(command[1]);
                    }
                }
                else if(command[0] == "Combine Items")
                {
                   var item = command[1]
                        .Split(":", StringSplitOptions.RemoveEmptyEntries);
                    if (inventory.Contains(item[0]))
                    {
                        int index = inventory.IndexOf(item[0]);
                        if(index == inventory.Count - 1)
                        {
                            inventory.Add(item[1]);
                            continue;
                        }
                        inventory.Insert(index+1,item[1]);
                    }
                }
                else if(command[0] == "Renew")
                {
                    if (inventory.Contains(command[1]))
                    {
                        inventory.Add(command[1]);
                        inventory.Remove(command[1]);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
