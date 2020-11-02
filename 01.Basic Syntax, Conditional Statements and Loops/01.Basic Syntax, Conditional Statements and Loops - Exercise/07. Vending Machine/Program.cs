using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        string money;
        double totalSum = 0;

        while ((money = Console.ReadLine()) != "Start")
        {
            if (money == "0.1" || money == "0.2" || money == "0.5" || money == "1" || money == "2")
            {
                totalSum += double.Parse(money);
            }
            else
            {
                Console.WriteLine($"Cannot accept {money}");
            }
        }
        string product;
        while ((product = Console.ReadLine()) != "End")
        {
            if (product == "Nuts" || product == "Soda" || product == "Coke" || product == "Crisps" || product == "Water")
            {
                if (product == "Nuts" && totalSum >= 2)
                {
                    totalSum -= 2;
                    Console.WriteLine($"Purchased nuts");
                }
                else if (product == "Water" && totalSum >= 0.7)
                {
                    totalSum -= 0.7;
                    Console.WriteLine($"Purchased water");
                }
                else if (product == "Crisps" && totalSum >= 1.5)
                {
                    totalSum -= 1.5;
                    Console.WriteLine($"Purchased crisps");
                }
                else if (product == "Coke" && totalSum >= 1)
                {
                    totalSum -= 1.0;
                    Console.WriteLine($"Purchased coke");
                }
                else if (product == "Soda" && totalSum >= 0.8)
                {
                    totalSum -= 0.8;
                    Console.WriteLine($"Purchased soda");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

            }
            else
            {
                Console.WriteLine("Invalid product");
            }
        }
        Console.WriteLine($"Change: {totalSum:f2}");
    }
}
