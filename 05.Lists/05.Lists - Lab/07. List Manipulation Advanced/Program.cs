using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
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
            List<int> firstList = new List<int>();
            firstList.AddRange(list);
            Command(list);


            if (!list.SequenceEqual(firstList))
            {
                Console.WriteLine(String.Join(" ", list));
            }

        }

        static void Command(List<int> list)
        {

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> listCommand = command.Split().ToList();
                if (listCommand[0] == "Add")
                {
                    AddNumber(list, int.Parse(listCommand[1]));
                }
                else if (listCommand[0] == "Remove")
                {
                    RemoveNumber(list, int.Parse(listCommand[1]));
                }
                else if (listCommand[0] == "RemoveAt")
                {
                    RemoveIndex(list, int.Parse(listCommand[1]));
                }
                else if (listCommand[0] == "Insert")
                {
                    InsertNumberAtIndex(list, int.Parse(listCommand[1]), int.Parse(listCommand[2]));
                }
                else if (listCommand[0] == "Contains")
                {
                    ContainsNumberAtList(list, int.Parse(listCommand[1]));
                }
                else if (listCommand[0] == "PrintEven")
                {
                    PrintEvenNumberAtList(list);
                }
                else if (listCommand[0] == "PrintOdd")
                {
                    PrintOddsNumberAtList(list);
                }
                else if (listCommand[0] == "GetSum")
                {
                    Console.WriteLine(ReturnSumOfAllNumbersAtList(list));
                }
                else if (listCommand[0] == "Filter")
                {
                    PrintFilteredNumber(list, listCommand[1], int.Parse(listCommand[2]));
                }
            }


        }
        static List<int> AddNumber(List<int> list, int number)
        {
            list.Add(number);
            return list;
        }
        static List<int> RemoveNumber(List<int> list, int number)
        {
            list.Remove(number);
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
        static void ContainsNumberAtList(List<int> list, int number)
        {

            if (list.Contains(number))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
            return;
        }
        static void PrintEvenNumberAtList(List<int> list)
        {
            List<int> evenNumber = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    evenNumber.Add(list[i]);
                }
            }
            Console.WriteLine(String.Join(" ", evenNumber));
            return;
        }
        static void PrintOddsNumberAtList(List<int> list)
        {
            List<int> oddNumber = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 != 0)
                {
                    oddNumber.Add(list[i]);
                }
            }
            Console.WriteLine(String.Join(" ", oddNumber));
            return;
        }
        static int ReturnSumOfAllNumbersAtList(List<int> list)
        {
            int sum = 0;
            foreach (int number in list)
            {
                sum += number;
            }
            return sum;
        }
        static void PrintFilteredNumber(List<int> list, string index, int number)
        {
            List<int> numbers = new List<int>();
            foreach (int digit in list)
            {
                if (index == ">" && digit > number)
                {
                    numbers.Add(digit);
                }

                else if (index == ">=" && digit >= number)
                {
                    numbers.Add(digit);
                }
                if (index == "<" && digit < number)
                {
                    numbers.Add(digit);
                }

                else if (index == "<=" && digit <= number)
                {
                    numbers.Add(digit);
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
            return;

        }

    }
}
