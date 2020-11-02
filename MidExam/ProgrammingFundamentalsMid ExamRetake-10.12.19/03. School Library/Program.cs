using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._School_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfBooks = Console.ReadLine()
                 .Split("&", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
            string command;
            while((command = Console.ReadLine()) != "Done")
            {
                string[] text = command
                    .Split(" | ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string action = text[0];
                if(action == "Add Book")
                {
                    if (!listOfBooks.Contains(text[1]))
                    {
                        AddBookOnFirstPlaceInList(listOfBooks, text[1]);
                    }
                }
                else if (action == "Take Book")
                {
                    if (listOfBooks.Contains(text[1]))
                    {
                        RemoveBook(listOfBooks, text[1]);
                    }
                }
                else if (action == "Swap Books")
                {
                    if (listOfBooks.Contains(text[1]) && listOfBooks.Contains(text[2]))
                    {
                        SwapBookInList(listOfBooks, text[1], text[2]);
                    }
                }
                else if (action == "Insert Book")
                {
                        AddBookInTheLastIndex(listOfBooks,text[1]);
                }
                else if (action == "Check Book")
                {
                    if(int.Parse(text[1]) >= 0 && int.Parse(text[1]) < listOfBooks.Count)
                    {
                        CheckTheBook(listOfBooks, int.Parse(text[1]));
                    }
                }
            }
            Console.WriteLine(string.Join(", ", listOfBooks));
        }
        static void AddBookOnFirstPlaceInList(List<string> listOfBooks, string book)
        {
            listOfBooks.Insert(0, book);
        }
        static void RemoveBook(List<string> listOfBook,string book)
        {
            listOfBook.Remove(book);
        }
        static void SwapBookInList(List<string> listOfBooks,string firstBook,string secondBook)
        {
            int indexOfFirstBook = listOfBooks.IndexOf(firstBook);
            int indexOfSecondBook = listOfBooks.IndexOf(secondBook);
            listOfBooks[indexOfFirstBook] = secondBook;
            listOfBooks[indexOfSecondBook] = firstBook;

        }
        static void AddBookInTheLastIndex(List<string> listOfBooks,string book)
        {
            listOfBooks.Add(book);
        }
        static void CheckTheBook(List<string> listOfBooks,int index)
        {
            Console.WriteLine(listOfBooks[index]);
        }
    }
}
