using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingList = new Dictionary<string, string>();
            int number = int.Parse(Console.ReadLine());
            ReceiveCommand(parkingList, number);
            PrintResult(parkingList);
        }

        static Dictionary<string, string> ReceiveCommand(Dictionary<string, string> parkingList, int number)
        {
            for (int i = 0; i < number; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string nameOfClient = command[1];
                if (command[0] == "register")
                {
                    string licenseNumber = command[2];
                    RegisterCar(parkingList, nameOfClient, licenseNumber);
                }
                else if (command[0] == "unregister")
                {
                    UnregisterCar(parkingList, nameOfClient);
                }
            }

            return parkingList;
        }

        static Dictionary<string, string> RegisterCar(Dictionary<string, string> parkingList, string nameOfClient, string licenseNumber)
        {
            if (!parkingList.ContainsKey(nameOfClient))
            {
                parkingList.Add(nameOfClient, licenseNumber);
                Console.WriteLine($"{nameOfClient} registered {licenseNumber} successfully");
            }
            else
            {
                Console.WriteLine($"ERROR: already registered with plate number {licenseNumber}");
            }
            return parkingList;
        }
        static Dictionary<string, string> UnregisterCar(Dictionary<string, string> parkingList, string nameOfClient)
        {
            if (parkingList.ContainsKey(nameOfClient))
            {
                parkingList.Remove(nameOfClient);
                Console.WriteLine($"{nameOfClient} unregistered successfully");
            }
            else
            {
                Console.WriteLine($"ERROR: user {nameOfClient} not found");
            }
            return parkingList;
        }

        static void PrintResult(Dictionary<string, string> parkingList)
        {
            foreach (var client in parkingList)
            {
                Console.WriteLine($"{client.Key} => {client.Value}");
            }
        }

    }
}
