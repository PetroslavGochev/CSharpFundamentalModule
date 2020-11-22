using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string pattern = @"\@[#]+[A-Z]+[A-Za-z\d]{4,}[A-Z]+\@[#]+";
            string digit = @"[\d]+";
            for (int i = 0; i < number; i++)
            {
                Match match = Regex.Match(Console.ReadLine(), pattern);
                if(match.Length == 0)
                {
                    Console.WriteLine("Invalid barcode");
                }
                else
                {
                    MatchCollection group = Regex.Matches(match.ToString(), digit);
                    if(group.Count == 0)
                    {
                        Console.WriteLine("Product group: 00");
                        continue;
                    }
                    StringBuilder barcode = new StringBuilder();
                    foreach (var dig in group)
                    {
                        barcode.Append(dig);
                    }
                    Console.WriteLine($"Product group: {barcode}");
                }
            }
        }
    }
}
