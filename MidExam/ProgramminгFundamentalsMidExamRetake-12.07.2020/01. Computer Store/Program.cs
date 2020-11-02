using System;
using System.Text;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            decimal priceWithoutTaxes = 0;
            decimal taxes = 0;
            decimal totalPrice = 0;
            while((input = Console.ReadLine()) != "regular" && input != "special")
            {
                decimal money = decimal.Parse(input);
                if(money < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                priceWithoutTaxes += money;
            }
            taxes = priceWithoutTaxes * 0.20M;
            totalPrice = taxes + priceWithoutTaxes;
            if(input == "special")
            {
                totalPrice *= 0.90M;
            }
            if(totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Congratulations you've just bought a new computer!");
            result.AppendLine($"Price without taxes: {priceWithoutTaxes:f2}$");
            result.AppendLine($"Taxes: {taxes:f2}$");
            result.AppendLine($"-----------");
            result.Append($"Total price: {totalPrice:f2}$");
            Console.WriteLine(result);
        }
    }
}
