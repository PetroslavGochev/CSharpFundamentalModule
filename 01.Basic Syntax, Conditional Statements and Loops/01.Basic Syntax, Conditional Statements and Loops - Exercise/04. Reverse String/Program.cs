using System;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string revere = "";
            int length = name.Length - 1;

            while (length >= 0)
            {
                revere = revere + name[length];
                length--;

            }
            Console.WriteLine(revere);
        }
    }
}
