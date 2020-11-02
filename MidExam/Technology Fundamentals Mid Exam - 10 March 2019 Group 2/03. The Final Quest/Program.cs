using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _03._The_Final_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> messages = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
            string command;
            while((command = Console.ReadLine())!= "Stop")
            {
                string[] action = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string typeOfAction = action[0];
                if(typeOfAction == "Delete")
                {
                    int index = int.Parse(action[1]) + 1;
                    if(index >= 0 && index < messages.Count)
                    {
                        DeleteIndex(messages, index);
                    }

                }
                else if(typeOfAction == "Swap")
                {
                    string word1 = action[1];
                    string word2 = action[2];
                    if(messages.Contains(word1) && messages.Contains(word2))
                    {
                        SwapIndex(messages, word1, word2);
                    }
                }
                else if(typeOfAction == "Put")
                {
                    int index = int.Parse(action[2]) - 1;
                    
                    if(index >= 0 && index <messages.Count)
                    {
                        PutElementOnIndex(messages, action[1], index);
                    }
                }
                else if(typeOfAction == "Sort")
                {
                   messages =  messages.OrderByDescending(x => x).ToList();
                }
                else if (typeOfAction == "Replace")
                {
                    string word1 = action[1];
                    string word2 = action[2];
                    if (messages.Contains(word2))
                    {
                        ReplaceWord(messages, word1, word2);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", messages));
        }
        static void DeleteIndex (List<string> messages, int index)
        {
            messages.RemoveAt(index);
        }
        static void SwapIndex(List<string> messages,string word1,string word2)
        {
            int indexWord1 = messages.FindIndex(x => x == word1);
            int indexWord2 = messages.FindIndex(x => x == word2);
            string temp = messages[indexWord1];
            messages[indexWord1] = messages[indexWord2];
            messages[indexWord2] = temp;
        }
        static void PutElementOnIndex (List<string> messages, string word,int index)
        {
            messages.Insert(index, word);
        }
        static void ReplaceWord(List<string> messages,string word1,string word2)
        {
            int index = messages.FindIndex(x => x == word2);
            messages[index] = word1;
        }
    }
}
