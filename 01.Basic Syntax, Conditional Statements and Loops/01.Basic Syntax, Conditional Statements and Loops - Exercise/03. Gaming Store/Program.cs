using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            string gameName;
            decimal totalSum = 0;
            while ((gameName = Console.ReadLine()) != "Game Time")
            {
                decimal price = 0;

                if (gameName == "OutFall 4")
                {
                    price = 39.99M;
                }
                else if (gameName == "CS: OG")
                {
                    price = 15.99M;
                }
                else if (gameName == "Zplinter Zell")
                {
                    price = 19.99M;
                }
                else if (gameName == "Honored 2")
                {
                    price = 59.99M;
                }
                else if (gameName == "RoverWatch")
                {
                    price = 29.99M;
                }
                else if (gameName == "RoverWatch Origins Edition")
                {
                    price = 39.99M;
                }
                else
                {
                    Console.WriteLine($"Not Found");
                    continue;
                }
                if (price > money)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    totalSum += price;
                    money -= price;
                    Console.WriteLine($"Bought {gameName}");
                }
                if (money == 0)
                {
                    Console.WriteLine("Out of money!");
                }

            }
            if (money > 0)
            {
                Console.WriteLine($"Total spent: ${totalSum:f2}. Remaining: ${money:f2}");
            }
        }
    }
}
