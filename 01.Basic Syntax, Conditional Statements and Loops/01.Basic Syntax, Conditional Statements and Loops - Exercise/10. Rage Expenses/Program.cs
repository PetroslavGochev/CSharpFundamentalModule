using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        int lostGame = int.Parse(Console.ReadLine());
        double priceForHeadset = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());
        double totalPrice = 0.0;
        int keyboard = 0;
        int mouse = 0;
        int headset = 0;
        int display = 0;


        for (int lost = 1; lost <= lostGame; lost++)
        {
            if (lost % 2 == 0 && lost % 3 == 0)
            {
                keyboard++;
                mouse++;
                headset++;
            }
            else if (lost % 2 == 0)
            {
                headset++;
            }
            else if (lost % 3 == 0)
            {
                mouse++;
            }
        }
        display += keyboard / 2;
        totalPrice += (mouse * mousePrice) + (keyboard * keyboardPrice) + (display * displayPrice) + (headset * priceForHeadset);
        Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
    }
}
