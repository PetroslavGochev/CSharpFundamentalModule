using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            Dictionary<string, int> dictOfProduct = new Dictionary<string, int>();
            while ((command = Console.ReadLine()) != "stop")
            {
                int readQuantity = int.Parse(Console.ReadLine());

                if (dictOfProduct.ContainsKey(command))
                {
                    dictOfProduct[command] += readQuantity;
                }
                else
                {
                    dictOfProduct.Add(command, readQuantity);
                }
            }
            foreach (var index in dictOfProduct)
            {
                Console.WriteLine($"{index.Key} -> {index.Value}");
            }
        }
    }
}
