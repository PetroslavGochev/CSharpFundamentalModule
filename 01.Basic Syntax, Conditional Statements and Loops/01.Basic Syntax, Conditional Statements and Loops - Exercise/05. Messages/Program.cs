using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string text = "";

            for (int i = 1; i <= number; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num == 2 || num == 22 || num == 222)
                {
                    if (num == 2)
                    {
                        text += "a";
                    }
                    else if (num == 22)
                    {
                        text += "b";
                    }
                    else
                    {
                        text += "c";
                    }
                }
                else if (num == 3 || num == 33 || num == 333)
                {
                    if (num == 3)
                    {
                        text += "d";
                    }
                    else if (num == 33)
                    {
                        text += "e";
                    }
                    else
                    {
                        text += "f";
                    }
                }
                else if (num == 4 || num == 44 || num == 444)
                {
                    if (num == 4)
                    {
                        text += "g";
                    }
                    else if (num == 44)
                    {
                        text += "h";
                    }
                    else
                    {
                        text += "i";
                    }
                }
                else if (num == 5 || num == 55 || num == 555)
                {
                    if (num == 5)
                    {
                        text += "j";
                    }
                    else if (num == 55)
                    {
                        text += "k";
                    }
                    else
                    {
                        text += "l";
                    }
                }
                else if (num == 6 || num == 66 || num == 666)
                {
                    if (num == 6)
                    {
                        text += "m";
                    }
                    else if (num == 66)
                    {
                        text += "n";
                    }
                    else
                    {
                        text += "o";
                    }
                }
                else if (num == 7 || num == 77 || num == 777 || num == 7777)
                {
                    if (num == 7)
                    {
                        text += "p";
                    }
                    else if (num == 77)
                    {
                        text += "q";
                    }
                    else if (num == 777)
                    {
                        text += "r";
                    }
                    else
                    {
                        text += "s";
                    }
                }
                else if (num == 8 || num == 88 || num == 888)
                {
                    if (num == 8)
                    {
                        text += "t";
                    }
                    else if (num == 88)
                    {
                        text += "u";
                    }
                    else
                    {
                        text += "v";
                    }
                }
                else if (num == 9 || num == 99 || num == 9999 || num == 999)
                {
                    if (num == 9)
                    {
                        text += "w";
                    }
                    else if (num == 99)
                    {
                        text += "x";
                    }
                    else if (num == 999)
                    {
                        text += "y";
                    }
                    else
                    {
                        text += "z";
                    }
                }
                else if (num == 0)
                {
                    text += " ";
                }
            }
            Console.WriteLine(text);
        }
    }
}
