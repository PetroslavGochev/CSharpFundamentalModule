using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int absNumber = Math.Abs(number);
            string n = absNumber.ToString();
            Console.WriteLine(GetSumOfEvenOrOddsDigit(n));


        }
        static int GetSumOfEvenOrOddsDigit(string number)
        {
            int sumEven = 0;
            int sumOdd = 0;
            for (int i = 0; i < number.Length; i++)
            {


                if (int.Parse(number[i].ToString()) % 2 == 0)
                {
                    sumEven += int.Parse(number[i].ToString());
                }
                else
                {
                    sumOdd += int.Parse(number[i].ToString());
                }

            }
            return GetMultiplyOfEvenAndOdds(sumEven, sumOdd);
        }

        static int GetMultiplyOfEvenAndOdds(int resultOne, int resultTwo)
        {
            int result = 0;
            result = resultOne * resultTwo;

            return result;
        }
    }
}
