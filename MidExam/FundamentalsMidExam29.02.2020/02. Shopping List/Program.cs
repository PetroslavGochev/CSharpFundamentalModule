using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                 .Split("!", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                string[] command = input.Split();
                string name = command[0];
                if(name == "Urgent")
                {
                    if (!list.Contains(command[1]))
                    {
                        list.Insert(0,command[1]);
                    }
                }
                else if(name == "Unnecessary")
                {
                    if (list.Contains(command[1]))
                    {
                        list.Remove(command[1]);
                    }
                }
                else if(name == "Correct")
                {
                    if (list.Contains(command[1]))
                    {
                        int index = list.IndexOf(command[1]);
                        list[index] = command[2];
                    }
                }
                else if(name == "Rearrange")
                {
                    if (list.Contains(command[1]))
                    {
                        list.Remove(command[1]);
                        list.Add(command[1]);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
