using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int divisible = 0;

        if (number % 2 == 0)
        {
            divisible = 2;
        }
        if (number % 3 == 0)
        {
            divisible = 3;
        }
        if (number % 6 == 0)
        {
            divisible = 6;
        }
        if (number % 7 == 0)
        {
            divisible = 7;
        }
        if (number % 10 == 0)
        {
            divisible = 10;
        }
        if (divisible == 0)
        {
            Console.WriteLine("Not divisible");
        }
        else
        {
            Console.WriteLine($"The number is divisible by {divisible}");
        }
    }
}
