using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int command = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < number; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                for (int k = 0; k < command; k++)
                {
                    symbol++;
                }
                result.Append($"{symbol}");
            }
            Console.WriteLine($"{result.ToString()}");
        }
    }
}
