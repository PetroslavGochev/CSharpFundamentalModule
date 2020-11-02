using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            List<int> listOfWagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            for (int i = 0; i < listOfWagons.Count; i++)
            {
                int freePlace = 4 - listOfWagons[i];
                if(freePlace == 0)
                {
                    continue;
                }
                if(numberOfPeople < freePlace)
                {
                    listOfWagons[i] += numberOfPeople;
                    numberOfPeople = 0;
                    Console.WriteLine("The lift has empty spots!");
                    break;
                }
                else
                {
                    listOfWagons[i] += freePlace;
                    numberOfPeople -= freePlace;
                }
            }
            if(numberOfPeople > 0)
            {
                Console.WriteLine($"There isn't enough space! {numberOfPeople} people in a queue!");
            }
            Console.WriteLine(string.Join(" ", listOfWagons));

        }
    }
}
