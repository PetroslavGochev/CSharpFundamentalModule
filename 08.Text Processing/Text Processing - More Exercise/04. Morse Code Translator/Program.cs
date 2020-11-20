using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            var translater = new Dictionary<string, char>()
            {
                {".-",'A'},
                {"-...",'B'},
                {"-.-.",'C'},
                {"-..",'D'},
                {".",'E' },
                {"..-.",'F'},
                {"--.",'G' },
                {"....",'H'},
                {"..",'I'},
                {".---",'J'},
                {"-.-",'K'},
                {".-..",'L'},
                {"--",'M'},
                {"-.",'N'},
                {"---",'O'},
                {".--.",'P'},
                {"--.-",'Q'},
                {".-.",'R'},
                {"...",'S'},
                {"-",'T'},
                {"..-",'U'},
                {"...-",'V'},
                {".--",'W'},
                {"-..-",'X'},
                {"-.--",'Y'},
                {"--..",'Z'},
                {"|",' ' },
            };
            string[] morseCode = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            StringBuilder message = new StringBuilder();
            foreach (var word in morseCode)
            {
                message.Append($"{translater[word]}");
            }
            Console.WriteLine(message.ToString().Trim());
        }
    }
}
