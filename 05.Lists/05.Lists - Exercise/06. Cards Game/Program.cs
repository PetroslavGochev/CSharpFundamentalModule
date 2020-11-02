using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static List<int> ReturnList()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            return list;
        }
        static void Main(string[] args)
        {
            var firstPlayerCards = ReturnList();
            var secondPlayerCards = ReturnList();
            ReturnWinner(firstPlayerCards, secondPlayerCards);

        }

        static void ReturnWinner(List<int> firstPlayer, List<int> secondPlayer)
        {
            bool flag = true;
            int index = 0;
            string nameOfWinner = string.Empty;
            List<int> winner = new List<int>();
            while (flag)
            {

                if (firstPlayer[index] > secondPlayer[index])
                {
                    firstPlayer.Add(firstPlayer[index]);
                    firstPlayer.Add(secondPlayer[index]);
                    firstPlayer.RemoveAt(index);
                    secondPlayer.RemoveAt(index);
                }
                else if (secondPlayer[index] > firstPlayer[index])
                {
                    secondPlayer.Add(secondPlayer[index]);
                    secondPlayer.Add(firstPlayer[index]);
                    firstPlayer.RemoveAt(index);
                    secondPlayer.RemoveAt(index);
                }
                else
                {
                    firstPlayer.RemoveAt(index);
                    secondPlayer.RemoveAt(index);
                }
                if (firstPlayer.Count == 0 || secondPlayer.Count == 0)
                {
                    flag = false;
                }
            }
            if (firstPlayer.Count != 0)
            {
                winner = firstPlayer;
                nameOfWinner = "First player wins!";
            }
            else if (secondPlayer.Count != 0)
            {
                winner = secondPlayer;
                nameOfWinner = "Second player wins!";
            }

            Console.WriteLine($"{nameOfWinner} Sum: {ReturnSumOfWinner(winner)}");
            return;



        }

        static int ReturnSumOfWinner(List<int> winner)
        {

            return winner.Sum();
        }
    }
}
