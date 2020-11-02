using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            ReceiveID(companies);
            companies = companies.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
            Console.WriteLine(PrintListOfCompanies(companies));

        }

        static Dictionary<string, List<string>> ReceiveID(Dictionary<string, List<string>> companies)
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] receiveUser = command
                      .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                      .ToArray();
                string companyName = receiveUser[0];
                string userId = receiveUser[1];
                if (companies.ContainsKey(companyName))
                {
                    if (companies[companyName].Contains(userId))
                    {
                        continue;
                    }
                    companies[companyName].Add(userId);
                }
                else
                {
                    companies.Add(companyName, new List<string>());
                    companies[companyName].Add(userId);
                }

            }
            return companies;
        }
        static string PrintListOfCompanies(Dictionary<string, List<string>> companies)
        {
            StringBuilder result = new StringBuilder();
            foreach (var company in companies)
            {
                result.AppendLine(company.Key);
                foreach (var id in company.Value)
                {
                    result.AppendLine($"-- {id}");
                }
            }
            return result.ToString();
        }
    }
}
