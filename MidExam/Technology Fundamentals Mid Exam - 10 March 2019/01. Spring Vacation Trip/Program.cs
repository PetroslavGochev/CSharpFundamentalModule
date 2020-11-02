using System;
using System.Data.SqlTypes;

namespace _01._Spring_Vacation_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfTheirTrip = int.Parse(Console.ReadLine());
            double theirBudget = double.Parse(Console.ReadLine());
            int groupOfPeople = int.Parse(Console.ReadLine());
            double priceForFuelPerKm = double.Parse(Console.ReadLine());
            double foodPerPerson = double.Parse(Console.ReadLine());
            double priceForRoomForOneNight = double.Parse(Console.ReadLine());
            if(groupOfPeople > 10)
            {
                priceForRoomForOneNight *= 0.75;
            }
           double money = daysOfTheirTrip * groupOfPeople * (priceForRoomForOneNight + foodPerPerson);
            for (int i = 1; i <= daysOfTheirTrip; i++)
            {
                double traveledDistance = double.Parse(Console.ReadLine());
                money += traveledDistance * priceForFuelPerKm;
                if (i % 3 == 0 || i % 5 == 0)
                {
                    money += money * 0.4;
                }
                else if (i % 7 == 0)
                {
                    money -= money / groupOfPeople; 
                }
                if (money > theirBudget)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {money - theirBudget:f2}$ more.");
                    return;
                }
            }
                Console.WriteLine($"You have reached the destination. You have {theirBudget - money:f2}$ budget left.");
        }
    }
}
