using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayWeek = int.Parse(Console.ReadLine());

            string[] day = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (dayWeek < 1 || dayWeek > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine($"{day[dayWeek - 1]}");
            }
        }
    }
}
