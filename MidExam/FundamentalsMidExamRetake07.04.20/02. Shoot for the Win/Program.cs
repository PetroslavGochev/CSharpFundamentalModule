using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> target = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = string.Empty;
            int count = 0;
            while((command = Console.ReadLine()) != "End")
            {
                int index = int.Parse(command);
                if(index >= 0 && index < target.Count)
                {
                    
                    if(target[index] == -1)
                    {
                        continue;
                    }
                    int points = target[index];
                    count++;
                    for (int i = 0; i < target.Count; i++)
                    {
                        if(i == index || target[i] == -1)
                        {
                            target[i] = -1;
                        }
                        else if(target[i] > points)
                        {
                            target[i] -= points; 
                        }
                        else
                        {
                            target[i] += points;
                        }
                    }
                }
            }
            Console.WriteLine($"Shot targets: {count} -> {string.Join(" ", target)}");
        }

    }
}
