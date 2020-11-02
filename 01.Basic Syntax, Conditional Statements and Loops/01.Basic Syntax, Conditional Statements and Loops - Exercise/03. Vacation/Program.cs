using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int numberOfGroup = int.Parse(Console.ReadLine());
        string typeOfPeople = Console.ReadLine();
        string day = Console.ReadLine();
        double totalPrice = 0.0;

        if (typeOfPeople == "Students")
        {
            if (day == "Friday")
            {
                totalPrice += numberOfGroup * 8.45;
            }
            else if (day == "Saturday")
            {
                totalPrice += numberOfGroup * 9.80;
            }
            else
            {
                totalPrice += numberOfGroup * 10.46;
            }
            if (numberOfGroup >= 30)
            {
                totalPrice *= 0.85;
            }
        }
        else if (typeOfPeople == "Business")
        {
            if (numberOfGroup >= 100)
            {
                numberOfGroup -= 10;
            }
            if (day == "Friday")
            {
                totalPrice += numberOfGroup * 10.90;
            }
            else if (day == "Saturday")
            {
                totalPrice += numberOfGroup * 15.60;
            }
            else
            {
                totalPrice += numberOfGroup * 16;
            }

        }
        else
        {
            if (day == "Friday")
            {
                totalPrice += numberOfGroup * 15;
            }
            else if (day == "Saturday")
            {
                totalPrice += numberOfGroup * 20;
            }
            else
            {
                totalPrice += numberOfGroup * 22.50;
            }
            if (numberOfGroup >= 10 && numberOfGroup <= 20)
            {
                totalPrice *= 0.95;
            }
        }
        Console.WriteLine($"Total price: {totalPrice:F2}");

    }
}
