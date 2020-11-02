
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionaryOfName = new Dictionary<string, int>();
            List<string> listOfNames = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
            foreach (var name in listOfNames)
            {
                dictionaryOfName.Add(name, 0);
            }
            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                string regName = @"[\W\d]";
                string regNumber = @"[\WA-Za-z]";
                string name = Regex.Replace(input, regName, "");
                string allDigit = Regex.Replace(input, regNumber, "");
                int sum = 0;
                foreach (var digit in allDigit)
                {
                    sum += int.Parse(digit.ToString());
                }
                if (dictionaryOfName.ContainsKey(name))
                {
                    dictionaryOfName[name] += sum;
                }
            }

            dictionaryOfName = dictionaryOfName.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            int counter = 0;
            foreach (var name in dictionaryOfName)
            {
                counter++;
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {name.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {name.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {name.Key}");
                    break;
                }
            }
        }
    }
}
