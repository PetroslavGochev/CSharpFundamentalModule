using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
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
            var numberOfCommands = int.Parse(Console.ReadLine());
            List<string> listOfGuest = new List<string>();
            Command(numberOfCommands, listOfGuest);
            foreach (string name in listOfGuest)
            {
                Console.WriteLine(name);
            }
        }

        static List<string> Command(int number, List<string> listOfGuest)
        {
            for (int i = 1; i <= number; i++)
            {
                string command = Console.ReadLine();
                string[] arrayComand = command.Split().ToArray();
                if (arrayComand[2] == "going!")
                {
                    AddNameInList(arrayComand[0], listOfGuest);
                }
                else if (arrayComand[2] == "not")
                {
                    RemoveNameInList(listOfGuest, arrayComand[0]);
                }
            }
            return listOfGuest;
        }

        static List<string> AddNameInList(string name, List<string> listOfGuest)
        {
            bool flag = true;
            foreach (string names in listOfGuest)
            {
                if (names == name)
                {
                    Console.WriteLine($"{name} is already in the list!");
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                listOfGuest.Add(name);
            }
            return listOfGuest;
        }
        static List<string> RemoveNameInList(List<string> listOfGuest, string name)
        {
            bool flag = true;
            foreach (string names in listOfGuest)
            {
                if (names == name)
                {
                    listOfGuest.Remove(name);
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine($"{name} is not in the list!");
            }
            return listOfGuest;
        }
    }
}
