using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._Hello__France
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arrayOfProducts = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            decimal budget = decimal.Parse(Console.ReadLine());
            CalculateTheProduct(arrayOfProducts, budget);

        }
        static void CalculateTheProduct(List<string> listOfProducts, decimal budget)
        {
            decimal profit = 0;
            decimal startBudget = budget;
            decimal maximumPriceClothes = 50M;
            decimal maximumPriceShoes = 35M;
            decimal maximumPriceAccessories = 20.50M;
            List<decimal> listOfNewPrice = new List<decimal>();
            foreach (var article in listOfProducts)
            {
                string[] product = article
                    .Split("->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = product[0];
                decimal price = decimal.Parse(product[1]);
                if (name == "Shoes" && price > maximumPriceShoes)
                {
                    continue;
                }
                else if (name == "Accessories" && price > maximumPriceAccessories)
                {
                    continue;
                }
                else if (price > maximumPriceClothes)
                {
                    continue;
                }
                if (budget >= price)
                {
                    budget -= price;
                    decimal count = price * 0.4M;
                    profit += count;
                    price += count;
                    listOfNewPrice.Add(price);
                }
            }
            startBudget += profit;
            Console.WriteLine(ReturnResult(listOfNewPrice, profit, startBudget));
        }
        static string ReturnResult(List<decimal> listOfNewPrice, decimal profit, decimal startBudget)
        {
            StringBuilder result = new StringBuilder();
            decimal priceForTickets = 150M;
            foreach (var price in listOfNewPrice)
            {
                result.Append($"{price:f2} ");
            }
            result.AppendLine();
            result.AppendLine($"Profit: {profit:f2}");
            if (startBudget >= priceForTickets)
            {
                result.Append($"Hello, France!");
            }
            else
            {
                result.Append($"Time to go.");
            }
            return result.ToString().Trim();
        }
    }
}
