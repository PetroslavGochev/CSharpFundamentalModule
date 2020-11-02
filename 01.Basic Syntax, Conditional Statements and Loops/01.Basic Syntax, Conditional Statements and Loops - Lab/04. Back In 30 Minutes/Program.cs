using System;

namespace Unique_PIN_CODES
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalMinutes = (hours * 60) + minutes;
            int totalMinutesPlus30 = totalMinutes + 30;

            hours = totalMinutesPlus30 / 60;
            minutes = totalMinutesPlus30 % 60;

            if (hours == 24)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{minutes:d2}");

        }
    }
}
