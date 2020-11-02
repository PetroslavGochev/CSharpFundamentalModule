using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            decimal totalPrice = 0;
            List<MatchCollection> listOfCorrectMatches = new List<MatchCollection>();
            while ((input = Console.ReadLine()) != "Purchase")
            {
                MatchCollection correctText = Regex.Matches(input, @">>([A-Za-z\s]+)<<([0-9]+|[0-9]+.[0-9]+)!([0-9]+)");
                listOfCorrectMatches.Add(correctText);
            }
            Console.WriteLine("Bought furniture:");
            foreach (MatchCollection collection in listOfCorrectMatches)
            {
                foreach (Match product in collection)
                {
                    Console.WriteLine($"{product.Groups[1]}");
                    totalPrice += decimal.Parse(product.Groups[2].ToString()) * decimal.Parse(product.Groups[3].ToString());
                }
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }

    }
}



