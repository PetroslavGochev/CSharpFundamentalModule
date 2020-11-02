using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startinYield = int.Parse(Console.ReadLine());
            int totalAmount = 0;
            int day = 0;
            if (startinYield >= 100)
            {
                while (startinYield >= 100)
                {
                    day++;
                    totalAmount += startinYield - 26;
                    startinYield -= 10;
                }
                totalAmount -= 26;


            }
            Console.WriteLine(day);
            Console.WriteLine(totalAmount);
        }
    }
}
