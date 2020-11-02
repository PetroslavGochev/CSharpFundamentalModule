using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                Console.WriteLine(GetMax(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            }
            else if (type == "string")
            {
                Console.WriteLine(GetMax(Console.ReadLine(), Console.ReadLine()));
            }
            else
            {
                Console.WriteLine(GetMax(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine())));
            }
        }

        static char GetMax(char first, char second)
        {
            int result = first.CompareTo(second);
            char bigger = result > 0 ? first : second;
            return bigger;
        }
        static string GetMax(string first, string second)
        {
            int result = first.CompareTo(second);
            string bigger = result > 0 ? first : second;
            return bigger;
        }
        static int GetMax(int first, int second)
        {
            int result = first.CompareTo(second);
            int bigger = result > 0 ? first : second;
            return bigger;
        }
    }
}
