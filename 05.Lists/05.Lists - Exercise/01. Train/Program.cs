using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static List<int> ReturnList()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            return list;
        }
        static void Main(string[] args)
        {
            var list = ReturnList();
            var maxPassengersInWagon = int.Parse(Console.ReadLine());
            Command(list, maxPassengersInWagon);
            Console.WriteLine(String.Join(" ", list));
        }

        static List<int> Command(List<int> list, int maxPessengers)
        {
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arrayCommand = command.Split().ToArray();
                if (arrayCommand[0] == "Add")
                {
                    ReturnListWithNewWagon(list, int.Parse(arrayCommand[1]));
                }
                else
                {
                    ReturnListWithWagon(list, int.Parse(arrayCommand[0]), maxPessengers);
                }
            }
            return list;

        }

        static List<int> ReturnListWithNewWagon(List<int> listWithWagon, int number)
        {
            listWithWagon.Add(number);
            return listWithWagon;
        }
        static List<int> ReturnListWithWagon(List<int> list, int passengers, int max)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] + passengers <= max)
                {
                    list.Insert(i, list[i] + passengers);
                    list.RemoveAt(i + 1);
                    break;
                }
            }
            return list;
        }
    }
}
