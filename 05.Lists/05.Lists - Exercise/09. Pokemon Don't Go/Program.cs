using System;
using System.Collections.Generic;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static List<int> ReturnList()
        {
            List<int> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            return list;
        }
        static void Main(string[] args)
        {
            var list = ReturnList();
            Console.WriteLine(ReceiveCommand(list));
        }

        static int ReceiveCommand(List<int> list)
        {
            int totalSum = 0;
            while (list.Count > 0)
            {
                int command = int.Parse(Console.ReadLine());
                int number;

                if (command < 0)
                {
                    number = list[0];
                    list.RemoveAt(0);
                }
                else if (command >= list.Count)
                {
                    number = list[list.Count - 1];
                    list.RemoveAt(list.Count - 1);
                }
                else
                {
                    number = list[command];
                }

                if (command >= 0 && command < list.Count)
                {
                    list.RemoveAt(command);
                }

                for (int i = 0; i < list.Count; i++)
                {

                    if (list[i] <= number)
                    {
                        list[i] += number;
                    }
                    else
                    {
                        list[i] -= number;
                    }
                }
                if (command < 0)
                {
                    list.Insert(0, list[list.Count - 1]);
                }
                if (command > list.Count)
                {
                    list.Add(list[0]);
                }
                totalSum += number;
            }

            return totalSum;
        }
    }
}
