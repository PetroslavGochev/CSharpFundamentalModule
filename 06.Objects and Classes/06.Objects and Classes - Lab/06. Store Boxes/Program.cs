using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        public static void Main(string[] args)
        {
            string command;
            List<Item> items = new List<Item>();
            List<Box> boxes = new List<Box>();
            while ((command = Console.ReadLine()) != "end")
            {
                string[] product = command.Split().ToArray();
                Item item = new Item()
                {
                    Name = product[1],
                    Price = double.Parse(product[3])
                };
                items.Add(item); ;
                Box box = new Box()
                {
                    SerialNumber = product[0],
                    Item = item,
                    ItemQuantitiy = int.Parse(product[2]),
                    PriceForABox = int.Parse(product[2]) * item.Price
                };
                boxes.Add(box);
            }
            boxes = SortedListByPrice(boxes);
            foreach (Box box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantitiy}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");

            }

        }

        static List<Box> SortedListByPrice(List<Box> box)
        {
            List<Box> newList = box.OrderByDescending(x => x.PriceForABox).ToList();
            return newList;
        }

        public class Item
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }

        public class Box
        {
            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemQuantitiy { get; set; }
            public double PriceForABox { get; set; }
        }
    }
}