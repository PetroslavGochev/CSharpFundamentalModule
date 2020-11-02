using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {


        string user = Console.ReadLine();
        string correctPassword = "";
        int lenght = 0;
        lenght = user.Length - 1;
        while (lenght >= 0)
        {
            correctPassword += user[lenght];
            lenght--;
        }
        string password;
        int attempt = 0;
        while ((password = Console.ReadLine()) != correctPassword)
        {
            attempt++;
            if (attempt == 4)
            {
                Console.WriteLine($"User {user} blocked!");
                break;
            }
            else
            {
                Console.WriteLine($"Incorrect password. Try again.");
            }

        }
        if (password == correctPassword)
        {
            Console.WriteLine($"User {user} logged in.");
        }
    }
}
