using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfTom = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfCommands; i++)
            {
                var command = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if(command[0] == "Add")
                {
                    if (listOfTom.Contains(command[1]))
                    {
                        Console.WriteLine("Card is already bought");
                        continue;
                    }
                    listOfTom.Add(command[1]);
                    Console.WriteLine("Card successfully bought");
                }
                else if(command[0] == "Remove")
                {
                    if (listOfTom.Contains(command[1]))
                    {
                        listOfTom.Remove(command[1]);
                        Console.WriteLine($"Card successfully sold");
                        continue;
                    }
                    Console.WriteLine("Card not found");
                }
                else if (command[0] == "Remove At")
                {
                    int index = int.Parse(command[1]);
                    if(index>=0 && index < listOfTom.Count)
                    {
                        listOfTom.RemoveAt(index);
                        Console.WriteLine($"Card successfully sold");
                        continue;
                    }
                    Console.WriteLine("Index out of range");
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    if(index < 0 || index >= listOfTom.Count)
                    {
                        Console.WriteLine($"Index out of range");
                        continue;
                    }
                    if (listOfTom.Contains(command[2]))
                    {
                        Console.WriteLine("Card is already bought");
                        continue;
                    }
                    listOfTom.Insert(index, command[2]);
                    Console.WriteLine($"Card successfully bought");
                }
            }
            Console.WriteLine(string.Join(", ", listOfTom));
        }
    }
}
