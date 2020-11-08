using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> craft = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string input = string.Empty;
            while((input = Console.ReadLine()) != "Done")
            {
                var command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if(command[1] == "Left")
                {
                    int position = int.Parse(command[2]);
                    if(position > 0 && position < craft.Count)
                    {
                        string element = craft[position];
                        craft.RemoveAt(position);
                        craft.Insert(position - 1, element);
                        
                    }
                }
                else if (command[1] == "Right")
                {
                    int position = int.Parse(command[2]);
                    if (position >= 0 && position < craft.Count-1)
                    {
                        string element = craft[position];
                        craft.RemoveAt(position);
                        craft.Insert(position + 1, element);

                    }
                }
                else if (command[1] == "Odd")
                {
                    for (int i = 0; i < craft.Count; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.Write($"{craft[i]} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (command[1] == "Even")
                {
                    for (int i = 0; i < craft.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write($"{craft[i]} ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            StringBuilder result = new StringBuilder();
            foreach (var item in craft)
            {
                result.Append(item);
            }
            Console.WriteLine($"You crafted {result.ToString()}!");
        }
    }
}
