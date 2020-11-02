using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int startNumber = int.Parse(Console.ReadLine());
        int stopNumber = int.Parse(Console.ReadLine());
        int totalSum = 0;

        for (int i = startNumber; i <= stopNumber; i++)
        {
            if (i == stopNumber)
            {
                Console.Write(i);
            }
            else
            {
                Console.Write($"{i} ");
            }
            totalSum += i;
        }
        Console.WriteLine();
        Console.WriteLine($"Sum: {totalSum}");

    }
}
