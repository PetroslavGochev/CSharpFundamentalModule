using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> target = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string input = string.Empty;
            while((input = Console.ReadLine()) != "End")
            {
                string[] command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int index = int.Parse(command[1]);
                if (command[0] == "Shoot")
                {                  
                    int power = int.Parse(command[2]);
                    if(index >= 0 && index < target.Count)
                    {
                        target[index] -= power;
                        if(target[index] <= 0)
                        {
                            target.RemoveAt(index);
                        }
                    }
                }
                else if(command[0] == "Add")
                {
                    int value = int.Parse(command[2]);
                    if(index>=0 && index < target.Count)
                    {
                        target.Insert(index, value);
                        continue;
                    }
                    Console.WriteLine($"Invalid placement!");
                }
                else if(command[0] == "Strike")
                {
                    int radius = int.Parse(command[2]);
                    int start = index - radius;
                    int end = index + radius;
                    if(start>= 0 && end < target.Count)
                    {
                        target.RemoveRange(start, end - start +1);
                        continue;
                    }
                    Console.WriteLine($"Strike missed!");
                }
            }
            Console.WriteLine($"{string.Join("|", target)}");
        }
    }
}
