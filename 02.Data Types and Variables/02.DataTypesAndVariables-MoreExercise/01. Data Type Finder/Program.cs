using System;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            int integer;
            double doubleValue;
            bool boolValue;
            char charValue;

            while (text != "END")
            {
                if (int.TryParse(text, out integer))
                {
                    Console.WriteLine($"{text} is integer type");
                }
                else if (double.TryParse(text, out doubleValue))
                {
                    Console.WriteLine($"{text} is floating point type");
                }
                else if (bool.TryParse(text, out boolValue))
                {
                    Console.WriteLine($"{text} is boolean type");
                }
                else if (char.TryParse(text, out charValue))
                {
                    Console.WriteLine($"{text} is character type");
                }
                else
                {
                    Console.WriteLine($"{text} is string type");
                }
                text = Console.ReadLine();
            }
        }
    }
}
