using System;
using System.Text;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StringBuilder sb = new StringBuilder(Console.ReadLine());
            string input = string.Empty;
            while((input = Console.ReadLine()) != "Done")
            {
                var data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var command = data[0];
                if (command == "TakeOdd") TakeOdd(sb);
                else if (command == "Cut") Cut(sb, data);
                else if (command == "Substitute") Substitute(sb, data);
            }
            Console.WriteLine($"Your password is: {sb}");
        }
        static void TakeOdd(StringBuilder sb)
        {
            for (int i = 0; i < sb.Length; i++)
            {
                sb.Remove(i,1);
            }
            Console.WriteLine(sb);
        }
        static void Cut(StringBuilder sb,string[] input)
        {
            int index = int.Parse(input[1]);
            int length = int.Parse(input[2]);
            sb.Remove(index, length);
            Console.WriteLine(sb);  
        }
        static void Substitute(StringBuilder sb, string[] input)
        {
            string substring = input[1];
            string substitute = input[2];
            if (sb.ToString().Contains(substring))
            {
                sb.Replace(substring, substitute);
                Console.WriteLine(sb);
            }
            else
            {
                Console.WriteLine("Nothing to replace!");
            }
        }
    }
}
