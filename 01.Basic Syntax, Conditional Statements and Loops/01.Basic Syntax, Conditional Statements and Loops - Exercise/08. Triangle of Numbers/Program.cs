using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int currentNumber = 1;

        for (int row = 1; row <= number; row++)
        {
            for (int column = 1; column <= row; column++)
            {
                Console.Write($"{currentNumber} ");
            }
            Console.WriteLine();
            if (currentNumber == number)
            {
                break;
            }
            currentNumber++;
        }

    }
}
