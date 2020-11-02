using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Easter_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfProducts = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command;
            while ((command = Console.ReadLine()) != "No Money")
            {
                string[] text = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (text[0] == "OutOfStock")
                {
                    ChangeValue(listOfProducts, text[1]);
                }
                else if (text[0] == "Required")
                {
                    ReplaceProduct(listOfProducts, text[1], int.Parse(text[2]));
                }
                else if (text[0] == "JustInCase")
                {
                    AddProductOnLastIndex(listOfProducts, text[1]);
                }
            }
            listOfProducts.RemoveAll(x => x == "None");
            Console.WriteLine(string.Join(" ", listOfProducts));
        }
        static void ChangeValue(List<string> listOfProducts, string product)
        {
            for (int i = 0; i < listOfProducts.Count; i++)
            {
                if (listOfProducts[i] == product)
                {
                    listOfProducts.RemoveAt(i);
                    listOfProducts.Insert(i, "None");
                }
            }
        }
        static void ReplaceProduct(List<string> listOfProducts, string product, int index)
        {
            if (index > 0 && index < listOfProducts.Count)
            {
                listOfProducts.RemoveAt(index);
                listOfProducts.Insert(index, product);
            }
        }
        static void AddProductOnLastIndex(List<string> listOfProducts, string product)
        {
            listOfProducts.RemoveAt(listOfProducts.Count - 1);
            listOfProducts.Add(product);
        }
    }
}
