using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double gabsyMoney = double.Parse(Console.ReadLine());
            List<int> listOfDrum = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            ReceiveCommand(gabsyMoney, listOfDrum);
        }
        static void ReceiveCommand(double gabsyMoney, List<int> listOfDrum)
        {
            int[] savedQualityOfEachDream = listOfDrum.ToArray();
            string command;
            int price = 0;
            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int powerOfHit = int.Parse(command);
                for (int i = 0; i < listOfDrum.Count; i++)
                {
                    if (listOfDrum[i] < 1)
                    {
                        continue;
                    }
                    listOfDrum[i] -= powerOfHit;
                    if (listOfDrum[i] < 1)
                    {
                        price = savedQualityOfEachDream[i] * 3;
                        if (gabsyMoney >= price)
                        {
                            gabsyMoney -= price;
                            listOfDrum[i] = savedQualityOfEachDream[i];
                        }
                    }
                }
            }
            List<int> restDrum = ListOfRestDrum(listOfDrum);
            PrintResult(gabsyMoney, restDrum);
        }
        static List<int> ListOfRestDrum(List<int> listOfDrum)
        {
            List<int> restDrum = new List<int>();
            foreach (var drum in listOfDrum)
            {
                if (drum > 0)
                {
                    restDrum.Add(drum);
                }
            }
            return restDrum;
        }
        static void PrintResult(double gabsyMoney, List<int> drum)
        {
            Console.WriteLine(string.Join(" ", drum));
            Console.WriteLine($"Gabsy has {gabsyMoney:F2}lv.");
        }
    }
}
