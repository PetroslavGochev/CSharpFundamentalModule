using System;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                 .Split("|", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();
            int health = 100;
            int bitcoin = 0;
            int numberOfRoom = 0;
            for (int i = 0; i < input.Length; i++)
            {
                var room = input[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int value = int.Parse(room[1]);
                numberOfRoom++;
                if (room[0] == "potion")
                {
                    if (health + value > 100)
                    {
                        Console.WriteLine($"You healed for {100 - health} hp.");
                        health = 100;
                    }
                    else
                    {
                        health += value;
                        Console.WriteLine($"You healed for {value} hp.");
                    }
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (room[0] == "chest")
                {
                    Console.WriteLine($"You found {value} bitcoins.");
                    bitcoin += value;
                }
                else
                {
                    if (health > value)
                    {
                        health -= value;
                        Console.WriteLine($"You slayed {room[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {room[0]}.");
                        Console.WriteLine($"Best room: {numberOfRoom}");
                        return;
                    }
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoin}");
            Console.WriteLine($"Health: {health}");
        }
    }
}

