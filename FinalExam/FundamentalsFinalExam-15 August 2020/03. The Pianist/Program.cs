using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> piano = new Dictionary<string, List<string>>();
            int numberOfInput = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfInput; i++)
            {
                var data = ReturnArray();
                FillDictionary(piano, data);
            }
            while (true)
            {
                var input = ReturnArray();
                var command = input[0];
                if (IsTrue(command)) break;
                if (command == "Add") Add(piano, input);
                else if (command == "Remove") Remove(piano, input[1]);
                else if (command == "ChangeKey") ChangeKey(piano, input);
            }
            PrintResult(piano);
        }
        public static void FillDictionary(Dictionary<string, List<string>> piano, string[] data)
        {
            var key = data[2];
            var composer = data[1];
            var piece = data[0];
            if (!piano.ContainsKey(piece))
            {
                piano.Add(piece, new List<string>());
            }
            piano[piece].Add(composer);
            piano[piece].Add(key);
        }
        public static string[] ReturnArray() => Console.ReadLine()
            .Split("|", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        public static bool IsTrue(string command) => command == "Stop";
        public static void Add(Dictionary<string, List<string>> piano, string[] input)
        {
            var key = input[3];
            var composer = input[2];
            var piece = input[1];
            if (piano.ContainsKey(piece))
            {
                Console.WriteLine($"{piece} is already in the collection!");
            }
            else
            {
                piano.Add(piece, new List<string>());
                piano[piece].Add(composer);
                piano[piece].Add(key);
                Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
            }
        }
        public static void Remove(Dictionary<string, List<string>> piano, string piece)
        {
            if (piano.ContainsKey(piece))
            {
                piano.Remove(piece);
                Console.WriteLine($"Successfully removed {piece}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            }
        }
        public static void ChangeKey(Dictionary<string, List<string>> piano, string[] input)
        {
            var piece = input[1];
            var newKey = input[2];
            if (piano.ContainsKey(piece))
            {
                piano[piece][1] = newKey;
                Console.WriteLine($"Changed the key of {piece} to {newKey}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            }
        }
        public static void PrintResult(Dictionary<string, List<string>> piano)
        {
            foreach (var item in piano.OrderBy(x=>x.Key).ThenBy(x=>x.Value[0]))
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value[0]}, Key: {item.Value[1]}");
            }
        }
    }
}
