using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int copyNumber = number;
        int currentNumber = number;


        int sumFactorial = 0;

        while (currentNumber != 0)
        {
            copyNumber = currentNumber % 10;
            currentNumber /= 10;

            int factorial = 1;
            for (int i = 1; i <= copyNumber; i++)
            {
                factorial *= i;
            }
            sumFactorial += factorial;

        }
        if (sumFactorial == number)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
