using System;
using System.Text;

namespace Email_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string input = string.Empty;
            while((input = Console.ReadLine()) != "Complete")
            {
                var data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var command = data[0];
                if(command == "Make")
                {
                    var upperOrLower = data[1];
                    if (upperOrLower == "Lower")
                    {
                        email = Lower(email);
                    }
                    else if (upperOrLower == "Upper")
                    {
                        email = Upper(email);
                    }
                    Console.WriteLine(email);
                }
                else if (command == "GetDomain")
                {
                    int count = int.Parse(data[1]);
                    GetDomain(email, count);
                }
                else if (command == "GetUsername")
                {
                    GetUsername(email);
                }
                else if (command == "Replace")
                {
                    char replace = char.Parse(data[1]);
                    email = Replace(email, replace);
                    Console.WriteLine(email);
                }
                else if(command == "Encrypt")
                {
                    Encrypt(email);
                }
            }
        }
        public static string Upper(string email) => email.ToUpper();
        public static string Lower(string email) => email.ToLower();
        public static void GetDomain(string email,int count)
        {
            for (int i = email.Length - count; i < email.Length; i++)
            {
                Console.Write(email[i]);
            }
            Console.WriteLine();
        }
        public static void GetUsername(string email)
        {
            if (!email.Contains("@"))
            {
                Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
            }
            else
            {
                foreach (var symbol in email)
                {
                    if (symbol == '@') break;
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        public static string Replace(string email, char replace) => email.Replace(replace, '-');
        public static void Encrypt(string email)
        {
            foreach (var character in email)
            {
                Console.Write($"{(int)character} ");
            }
            Console.WriteLine();
        }

    }
}
