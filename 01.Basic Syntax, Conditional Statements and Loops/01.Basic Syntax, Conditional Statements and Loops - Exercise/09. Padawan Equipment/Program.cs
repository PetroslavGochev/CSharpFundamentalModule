using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        int countOfStudent = int.Parse(Console.ReadLine());
        double priceOfLightsabers = double.Parse(Console.ReadLine());
        double priceOfRobes = double.Parse(Console.ReadLine());
        double priceOfBelts = double.Parse(Console.ReadLine());

        double moreLightsabers = countOfStudent + (countOfStudent * 10.0 / 100.0);
        double beltsFree = 0.0;
        if (countOfStudent >= 6)
        {
            beltsFree += (countOfStudent / 6);
        }
        double totalPrice = Math.Ceiling(moreLightsabers) * priceOfLightsabers + countOfStudent * priceOfRobes + priceOfBelts * (countOfStudent - beltsFree);

        if (totalPrice > money)
        {
            Console.WriteLine($"Ivan Cho will need {Math.Abs(totalPrice - money):f2}lv more.");
        }
        else
        {
            Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
        }
    }
}
