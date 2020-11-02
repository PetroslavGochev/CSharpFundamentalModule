using System;

namespace Unique_PIN_CODES
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 3; i <= 99; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
