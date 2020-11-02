using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
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
            Command(list);
            Console.WriteLine(String.Join(" ", list));
        }

        static List<int> Command(List<int> list)
        {
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arrayCommand = command.Split().ToArray();
                if (arrayCommand[0] == "Delete")
                {
                    RemoveElementInList(list, int.Parse(arrayCommand[1]));
                }
                else if (arrayCommand[0] == "Insert")
                {
                    InsertElementInList(list, int.Parse(arrayCommand[1]), int.Parse(arrayCommand[2]));
                }
            }
            return list;

        }

        static List<int> RemoveElementInList(List<int> list, int element)
        {
            list.RemoveAll(item => item == element);
            return list;
        }
        static List<int> InsertElementInList(List<int> list, int element, int index)
        {
            list.Insert(index, element);
            return list;
        }

    }
}
