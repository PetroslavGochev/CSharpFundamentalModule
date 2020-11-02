using System;

namespace _01._Disneyland_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal priceForJourney = decimal.Parse(Console.ReadLine());
            int numberOfMonths = int.Parse(Console.ReadLine());
            decimal savedMoney = priceForJourney * 0.25M;
            decimal totalMoney = 0;
            for (int i = 1; i <= numberOfMonths; i++)
            {
                if (i % 2 != 0 && i != 1)
                {
                    totalMoney -= totalMoney * 0.16M;
                }
                if(i % 4 == 0)
                {
                    totalMoney += totalMoney * 0.25M;
                }
                totalMoney += savedMoney;
            }
            if(totalMoney >= priceForJourney)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {totalMoney - priceForJourney:f2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {priceForJourney - totalMoney:F2}lv. more.");
            }
        }
    }
}
