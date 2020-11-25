using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359([\s|-])2\1[\d]{3}\1[\d]{4}\b";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            MatchCollection collectionOfPhoneNumbers = regex.Matches(input);
            Console.WriteLine(string.Join(", ", collectionOfPhoneNumbers));
        }
    }
}
