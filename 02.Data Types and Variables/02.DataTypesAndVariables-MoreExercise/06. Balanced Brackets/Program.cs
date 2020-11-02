using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counterOpen = 0;
            int counterClosed = 0;
            bool isBalanced = true;
            for (int i = 0; i < number; i++)
            {
                string text = Console.ReadLine();
                if (text == "(")
                {
                    counterOpen++;

                }
                else if (text == ")")
                {
                    counterClosed++;
                    if (counterClosed - counterOpen != 0)
                    {
                        isBalanced = false;

                    }

                }
            }
            if (counterOpen == counterClosed && isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
