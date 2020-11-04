using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string input = string.Empty;
            StringBuilder child = new StringBuilder();
            string pattern = @"(?<name>@[A-Za-z]+)[^\@\-\:\>\!]*(?<behavior>\![G,N]{1}\!)";
            List<string> listOfGoodChild = new List<string>();
            while ((input = Console.ReadLine()) != "end")
            {
                foreach (var character in input)
                {
                    child.Append((char)(character - number));
                }
                Match match = Regex.Match(child.ToString(), pattern);
                if(match.Groups["behavior"].Value == "!G!")
                {
                    listOfGoodChild.Add(match.Groups["name"].Value);
                }
                child.Clear();
            }
            foreach (var kids in listOfGoodChild)
            {
                string kidsName =  kids.Substring(1,kids.Length-1);
                Console.WriteLine(kidsName);
            }
        }
    }
}
