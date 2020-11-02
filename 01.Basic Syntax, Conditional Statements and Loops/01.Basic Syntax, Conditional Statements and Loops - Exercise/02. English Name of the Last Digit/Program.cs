using System;

namespace _02._English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            int lastNumber = number % 10;

            Console.WriteLine(Number(lastNumber));

        }

        static string Number(int lastNumber)
        {
            string name = string.Empty;

            if (lastNumber == 0)
            {
                name = "zero";
            }
            else if (lastNumber == 1)
            {
                name = "one";
            }
            else if (lastNumber == 2)
            {
                name = "two";
            }
            else if (lastNumber == 3)
            {
                name = "three";
            }
            else if (lastNumber == 4)
            {
                name = "four";
            }
            else if (lastNumber == 5)
            {
                name = "five";
            }
            else if (lastNumber == 6)
            {
                name = "six";
            }
            else if (lastNumber == 7)
            {
                name = "seven";
            }
            else if (lastNumber == 8)
            {
                name = "eight";
            }
            else if (lastNumber == 9)
            {
                name = "nine";
            }

            return name;
        }
        }
}
