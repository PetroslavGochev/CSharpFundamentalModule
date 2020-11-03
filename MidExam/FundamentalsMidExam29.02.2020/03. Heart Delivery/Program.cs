using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> house = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int index = 0;
            string input = string.Empty;
            while((input = Console.ReadLine()) != "Love!")
            {
                string[] command = input.Split();
                int jump = int.Parse(command[1]);
                index += jump;
                if(index >= house.Count)
                {
                    index = 0;
                }
                if(house[index] == 0)
                {
                    Console.WriteLine($"Place {index} already had Valentine's day.");
                    continue;
                }
                house[index] -= 2;
                if(house[index] <= 0)
                {
                    Console.WriteLine($"Place {index} has Valentine's day.");
                    continue;
                }               
            }
            Console.WriteLine($"Cupid's last position was {index}.");
            index = 0;
            foreach (var item in house)
            {
                if(item > 0)
                {
                    index++;
                }
            }
            if (index > 0)
            {
                Console.WriteLine($"Cupid has failed {index} places.");
                return;
            }
            Console.WriteLine("Mission was successful.");

        }
    }
}
