using System;
using System.Text.RegularExpressions;

namespace Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"U\$(?<name>[A-Z][a-z]{2,})U\$P@\$(?<password>[A-Za-z]{5,}[\d]+)P@\$";
            int number = int.Parse(Console.ReadLine());
            int numberOfRegistration = 0;
            for (int i = 1; i <= number; i++)
            {
                Match match = Regex.Match(Console.ReadLine(), pattern);
                if(match.Length == 0)
                {
                    Console.WriteLine("Invalid username or password");
                    continue;
                }
                Console.WriteLine("Registration was successful");
                Console.WriteLine($"Username: {match.Groups["name"].Value}, Password: {match.Groups["password"].Value}");
                numberOfRegistration++;
            }
            Console.WriteLine($"Successful registrations: {numberOfRegistration}");
        }
    }
}
