using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_2._Easter_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfShops = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            int numberOfCommand = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfCommand; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] == "Include")
                {
                    AddTheShop(listOfShops, command[1]);
                }
                else if (command[0] == "Visit")
                {
                    if (int.Parse(command[2]) > listOfShops.Count || int.Parse(command[2]) < 0)
                    {
                        continue;
                    }
                    RemoveVisitShop(listOfShops, command[1], int.Parse(command[2]));
                }
                else if (command[0] == "Prefer")
                {
                    PreferShop(listOfShops, int.Parse(command[1]), int.Parse(command[2]));
                }
                else if (command[0] == "Place")
                {
                    InsertShop(listOfShops, command[1], int.Parse(command[2]) + 1);
                }
            }
            Console.WriteLine(PrintResult(listOfShops));
        }
        static void PreferShop(List<string> listOfShops, int shop1, int shop2)
        {
            if (shop1 >= 0 && shop1 < listOfShops.Count && shop2 >= 0 && shop2 < listOfShops.Count)
            {
                string firstShop = listOfShops[shop1];
                string secondShop = listOfShops[shop2];
                listOfShops[shop1] = secondShop;
                listOfShops[shop2] = firstShop;
            }
        }
        static void RemoveVisitShop(List<string> listOfShops, string visit, int index)
        {
            if (visit == "first")
            {
                listOfShops.RemoveRange(0, index);
            }
            else
            {
                listOfShops.RemoveRange(listOfShops.Count - index, index);
            }
        }

        static void InsertShop(List<string> listOfShops, string shop, int index)
        {
            if (index > 0 && index < listOfShops.Count)
            {
                listOfShops.Insert(index, shop);
            }
        }
        static void AddTheShop(List<string> listOfShops, string shop)
        {
            listOfShops.Add(shop);
        }
        static string PrintResult(List<string> listOfShops)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Shops left:");
            result.Append(string.Join(" ", listOfShops));
            return result.ToString();
        }
    }
}
