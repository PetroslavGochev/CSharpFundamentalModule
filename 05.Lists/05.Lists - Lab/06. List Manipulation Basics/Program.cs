using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
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
            var text = ReturnList();
            Command(text);

        }

        static void Command(List<int> text)
        {
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> listCommand = command.Split().ToList();
                if (listCommand[0] == "Add")
                {
                    AddNumber(text, int.Parse(listCommand[1]));
                }
                else if (listCommand[0] == "Remove")
                {
                    RemoveNumber(text, int.Parse(listCommand[1]));
                }
                else if (listCommand[0] == "RemoveAt")
                {
                    RemoveIndex(text, int.Parse(listCommand[1]));
                }
                else if (listCommand[0] == "Insert")
                {
                    InsertNumberAtIndex(text, int.Parse(listCommand[1]), int.Parse(listCommand[2]));
                }
            }
            Console.WriteLine(String.Join(" ", text));
        }
        static List<int> AddNumber(List<int> list, int index)
        {
            list.Add(index);
            return list;
        }
        static List<int> RemoveNumber(List<int> list, int index)
        {
            list.Remove(index);
            return list;
        }
        static List<int> RemoveIndex(List<int> list, int index)
        {
            list.RemoveAt(index);
            return list;
        }
        static List<int> InsertNumberAtIndex(List<int> list, int number, int index)
        {
            list.Insert(index, number);
            return list;
        }
    }
}
