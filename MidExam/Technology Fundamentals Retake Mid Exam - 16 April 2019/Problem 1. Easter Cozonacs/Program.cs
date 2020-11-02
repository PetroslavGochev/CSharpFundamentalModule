using System;

namespace Problem_1._Easter_Cozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            decimal priceForKgFloor = decimal.Parse(Console.ReadLine());
            decimal totalPrice = priceForKgFloor + (priceForKgFloor * 0.75M) + (priceForKgFloor * 1.25M * 0.250M);
            int numberOfEggs = 0;
            int numberOfCozonacs = 0;
            while (totalPrice < budget)
            {

                budget -= totalPrice;
                numberOfCozonacs++;
                numberOfEggs += 3;
                if(numberOfCozonacs % 3 == 0)
                {
                    int loseEggs = numberOfCozonacs - 2;
                    numberOfEggs -= loseEggs;
                }
            }
            Console.WriteLine($"You made {numberOfCozonacs} cozonacs! Now you have {numberOfEggs} eggs and {budget:f2}BGN left.");
        }
    }
}
