using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[A-Za-z0-9]+[\w\.\-]*[A-Za-z0-9]+@[A-Za-z]+[a-z\-\.]*\.[a-z]+";
            string[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<Match> listOfValidEmails = new List<Match>();
            foreach (var word in array)
            {
                Match validEmail = Regex.Match(word, pattern);
                if(validEmail.Length > 0)
                {
                    listOfValidEmails.Add(validEmail);
                }
                
            }
            foreach (var email in listOfValidEmails)
            {
               Console.WriteLine(email);
            }
        }
    }
}
