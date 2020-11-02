using System;

namespace _05._Print_Part_Of_ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSymbol = int.Parse(Console.ReadLine());
            int until = int.Parse(Console.ReadLine());

            for (char i = (char)firstSymbol; i <= until; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
