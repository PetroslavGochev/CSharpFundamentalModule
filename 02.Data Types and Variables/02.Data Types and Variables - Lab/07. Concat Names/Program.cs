using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondNae = Console.ReadLine();
            string delimeter = Console.ReadLine();

            Console.WriteLine($"{firstName}{delimeter}{secondNae}");
        }
    }
}
