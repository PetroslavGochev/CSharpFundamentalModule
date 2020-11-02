using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> products = new Dictionary<string, List<decimal>>();
            ReceiveProduct(products);
            PrintResult(BuyProduct(products));
        }

        static Dictionary<string, List<decimal>> ReceiveProduct(Dictionary<string, List<decimal>> products)
        {
            string receiveProduct;

            while ((receiveProduct = Console.ReadLine()) != "buy")
            {
                string[] product = receiveProduct
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string nameOfProduct = product[0];
                decimal priceOfProduct = decimal.Parse(product[1]);
                decimal quantityOfProduct = decimal.Parse(product[2]);
                AddProductInDictionary(nameOfProduct, priceOfProduct, quantityOfProduct, products);
            }
            return products;
        }
        static Dictionary<string, List<decimal>> AddProductInDictionary(string nameOfProduct, decimal priceOfProduct, decimal quantityOfProduct, Dictionary<string, List<decimal>> products)
        {
            if (products.ContainsKey(nameOfProduct))
            {
                products[nameOfProduct][1] += quantityOfProduct;
                products[nameOfProduct][0] = priceOfProduct;

            }
            else
            {
                products.Add(nameOfProduct, new List<decimal>());
                products[nameOfProduct].Add(priceOfProduct);
                products[nameOfProduct].Add(quantityOfProduct);
            }
            return products;
        }

        static Dictionary<string, decimal> BuyProduct(Dictionary<string, List<decimal>> products)
        {
            var buyDictionary = new Dictionary<string, decimal>();
            foreach (var product in products)
            {
                decimal price = (decimal)(product.Value[0] * product.Value[1]);
                buyDictionary.Add(product.Key, price);
            }
            return buyDictionary;
        }
        static void PrintResult(Dictionary<string, decimal> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value:f2}");
            }
        }
    }
}
