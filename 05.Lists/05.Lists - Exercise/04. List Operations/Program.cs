using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
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
            Console.WriteLine(string.Join(" ", list));

        }

        static List<int> Command(List<int> list)
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arrayCommand = command.Split().ToArray();
                if (arrayCommand[0] == "Add")
                {
                    AddIntegerInList(list, int.Parse(arrayCommand[1]));
                }
                else if (arrayCommand[0] == "Insert")
                {
                    if (int.Parse(arrayCommand[2]) > list.Count - 1 || int.Parse(arrayCommand[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        InsertIntegerInList(list, int.Parse(arrayCommand[1]), int.Parse(arrayCommand[2]));
                    }


                }
                else if (arrayCommand[1] == "left")
                {
                    ShiftLeftList(list, int.Parse(arrayCommand[2]));

                }
                else if (arrayCommand[1] == "right")
                {

                    ShiftRightList(list, int.Parse(arrayCommand[2]));

                }
                else if (arrayCommand[0] == "Remove")
                {
                    if (int.Parse(arrayCommand[1]) > list.Count - 1 || int.Parse(arrayCommand[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        RemoveIntegerInList(list, int.Parse(arrayCommand[1]));
                    }

                }
            }
            return list;
        }

        static List<int> AddIntegerInList(List<int> list, int number)
        {
            list.Add(number);
            return list;
        }
        static List<int> InsertIntegerInList(List<int> list, int number, int index)
        {
            list.Insert(index, number);
            return list;
        }
        static List<int> RemoveIntegerInList(List<int> list, int index)
        {
            list.RemoveAt(index);
            return list;
        }
        static List<int> ShiftLeftList(List<int> list, int number)
        {
            for (int i = 0; i < number; i++)
            {
                list.Add(list[0]);
                list.RemoveAt(0);

            }
            return list;
        }
        static List<int> ShiftRightList(List<int> list, int number)
        {

            for (int i = 0; i < number; i++)
            {
                list.Insert(0, list[list.Count - 1]);
                list.RemoveAt(list.Count - 1);
            }
            return list;
        }
    }
}
