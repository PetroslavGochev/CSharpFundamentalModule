using System;

namespace Unique_PIN_CODES
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            if (day == "Weekday")
            {
                if (age >= 0 && age <= 18)
                {
                    totalPrice += 12;
                }
                else if (age > 18 && age <= 64)
                {
                    totalPrice += 18;
                }
                else if (age > 64 && age <= 122)
                {
                    totalPrice += 12;
                }
                else
                {
                    totalPrice += 0;
                }
            }
            else if (day == "Weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    totalPrice += 15;
                }
                else if (age > 18 && age <= 64)
                {
                    totalPrice += 20;
                }
                else if (age > 64 && age <= 122)
                {
                    totalPrice += 15;
                }
                else
                {
                    totalPrice += 0;
                }
            }
            else
            {
                if (age >= 0 && age <= 18)
                {
                    totalPrice += 5;
                }
                else if (age > 18 && age <= 64)
                {
                    totalPrice += 12;
                }
                else if (age > 64 && age <= 122)
                {
                    totalPrice += 10;
                }
                else
                {
                    totalPrice += 0;
                }
            }
            if (totalPrice == 0)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine($"{totalPrice}$");
            }
        }
    }
}
