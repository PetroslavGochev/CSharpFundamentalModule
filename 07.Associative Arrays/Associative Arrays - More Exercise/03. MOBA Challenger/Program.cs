using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _03._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
            string receivePlayer = string.Empty;
            while((receivePlayer = Console.ReadLine())!= "Season end")
            {
                string[] input = receivePlayer
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if(input[1] == "vs")
                {
                    ComparePlayer(players, receivePlayer);
                }
                else if (input[1] == "->")
                {
                    AddPlayer(players, receivePlayer);
                }
            }
            Dictionary<string, int> playerTotalSkilss = new Dictionary<string, int>();
            foreach (var player in players)
            {
                playerTotalSkilss.Add(player.Key, player.Value.Sum(x=>x.Value));
            }
            Console.WriteLine(PrintResult(playerTotalSkilss, players));
        }
        static void AddPlayer(Dictionary<string, Dictionary<string, int>> players,string receivePlayer)
        {
            string[] input = receivePlayer
                .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string nameOfPlayer = input[0];
            string positionOfPlayer = input[1];
            int skillOfPlayer = int.Parse(input[2]);
            if (players.ContainsKey(nameOfPlayer))
            {
                if (players[nameOfPlayer].ContainsKey(positionOfPlayer))
                {
                    if(players[nameOfPlayer][positionOfPlayer] < skillOfPlayer)
                    {
                        players[nameOfPlayer][positionOfPlayer] = skillOfPlayer;
                    }
                }
                else
                {
                    players[nameOfPlayer].Add(positionOfPlayer, skillOfPlayer);
                }
            }
            else
            {
                players.Add(nameOfPlayer, new Dictionary<string, int>());
                players[nameOfPlayer].Add(positionOfPlayer, skillOfPlayer);
            }
        }
        static void ComparePlayer(Dictionary<string, Dictionary<string, int>> players,string receivePlayer)
        {
            string[] input = receivePlayer
                .Split(" vs ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string firstPlayerName = input[0];
            string secondPlayerName = input[1];
            if(players.ContainsKey(firstPlayerName) && players.ContainsKey(secondPlayerName))
            {
                foreach (var position in players[firstPlayerName])
                {
                    if (players[secondPlayerName].ContainsKey(position.Key))
                    {
                        if(players[firstPlayerName][position.Key] < players[secondPlayerName][position.Key])
                        {
                            players.Remove(firstPlayerName);
                            break;
                        }
                        else if (players[firstPlayerName][position.Key] > players[secondPlayerName][position.Key])
                        {
                            players.Remove(secondPlayerName);
                            break;
                        }
                    }
                }
            }
        }
        static string PrintResult(Dictionary<string, int> playerTotalSkilss, Dictionary<string, Dictionary<string, int>> players)
        {
            StringBuilder result = new StringBuilder();
            foreach (var player in playerTotalSkilss.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key).ToDictionary(x=>x.Key,y=>y.Value))
            {
                result.AppendLine($"{player.Key}: {player.Value} skill");
                foreach (var position in players[player.Key].OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value))
                {
                    result.AppendLine($"- {position.Key} <::> {position.Value}");
                }
            }
            return result.ToString().Trim();
            
        }
    }
}
