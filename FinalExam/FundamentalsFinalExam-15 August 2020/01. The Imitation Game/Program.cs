using System;
using System.Text;

namespace _01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder message = new StringBuilder(Console.ReadLine());
            string input = string.Empty;
            while((input = Console.ReadLine()) != "Decode")
            {
                var data = input
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                var command = data[0];
                if(command == "Move")
                {
                    int n = int.Parse(data[1]);
                    Move(message, n);
                }
                else if(command == "Insert")
                {
                    int index = int.Parse(data[1]);
                    string value = data[2];
                    Insert(message, index, value);
                }
                else if(command == "ChangeAll")
                {
                    string substring = data[1];
                    string value = data[2];
                    ChangeAll(message, substring, value);

                }
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }
        public static void Move(StringBuilder message,int n)
        {
            int index = 0;
            while (n != 0)
            {
                char symbol = message[index];
                message.Append(symbol);
                message.Remove(index, 1);
                n--;
            }
        }
        public static void Insert(StringBuilder message, int index,string value)
        {
            message.Insert(index, value);
        }
        public static void ChangeAll(StringBuilder message,string old,string value)
        {
            message.Replace(old, value);
        }

    }
}
