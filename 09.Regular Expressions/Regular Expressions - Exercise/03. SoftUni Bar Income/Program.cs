using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>[\w]+)>[^|$%.]*\|(?<quantity>[\d]+)\|[^|$%.]*?(?<price>[\d]+\.?[\d]+)\$";
            string input;
            decimal totaIncome = 0;
            while((input = Console.ReadLine())!= "end of shift")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    decimal totalPrice = decimal.Parse(match.Groups["quantity"].Value) * decimal.Parse(match.Groups["price"].Value);
                    Console.WriteLine($"{match.Groups["name"].Value}: {match.Groups["product"].Value} - {totalPrice:f2}");
                    totaIncome += totalPrice;
                }
            }
            Console.WriteLine($"Total income: {totaIncome:f2}");
        }
    }
}
