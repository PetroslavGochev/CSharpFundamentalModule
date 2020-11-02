using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Grade(double.Parse(Console.ReadLine()));
        }
        static void Grade(double grade)
        {
            if (grade > 3.00 && grade <= 3.49)
            {
                Console.WriteLine($"Poor");
            }
            else if (grade > 3.49 && grade <= 4.49)
            {
                Console.WriteLine($"Good");
            }
            else if (grade > 4.49 && grade <= 5.49)
            {
                Console.WriteLine($"Very good");
            }
            else if (grade > 5.49 && grade <= 6)
            {
                Console.WriteLine($"Excellent");
            }
            else
            {
                Console.WriteLine($"Fail");
            }
        }
    }
}
