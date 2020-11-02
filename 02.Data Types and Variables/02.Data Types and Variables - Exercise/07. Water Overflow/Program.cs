using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int waterTank = 255;
            int waterLiters = 0;

            for (int i = 1; i <= number; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (liters > waterTank)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                waterTank -= liters;
                waterLiters += liters;

            }
            Console.WriteLine(waterLiters);
        }
    }
}
