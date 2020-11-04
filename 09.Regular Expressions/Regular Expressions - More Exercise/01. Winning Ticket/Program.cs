using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string pattern = @".{10}";
            string patternTickets = @"(\@{6,}|\${6,}|\^{6,}|\#{6,})";
            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                MatchCollection match = Regex.Matches(ticket, pattern);
                string leftSide = string.Empty;
                string rightSide = string.Empty;
                for (int i = 0; i < 2; i++)
                {
                    Match matches = Regex.Match(match[i].Value.ToString(), patternTickets);
                    if(i == 0)
                    {
                        leftSide = matches.Value;
                    }
                    else if(i == 1)
                    {
                        rightSide = matches.Value;
                    }
                }
                int length = Math.Min(leftSide.Length, rightSide.Length);
                leftSide = leftSide.Substring(0, length);
                rightSide = rightSide.Substring(0, length);
                if (length >= 6 && leftSide.Equals(rightSide))
                {
                    char symbol = (char)leftSide[0];

                    if (length == 10)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {length}{symbol} Jackpot!");
                        continue;
                    }
                    Console.WriteLine($"ticket \"{ticket}\" - {length}{symbol}");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }


            }
        }
    }
}

