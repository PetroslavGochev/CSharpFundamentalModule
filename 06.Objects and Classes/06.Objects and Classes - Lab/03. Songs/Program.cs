using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numOfSong = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 1; i <= numOfSong; i++)
            {

                string[] data = Console.ReadLine().Split("_").ToArray();
                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();
                song.TypeList = type;
                song.NameOfSong = name;
                song.TimeOfSong = time;
                songs.Add(song);
            }
            string typeOfSong = Console.ReadLine();
            if (typeOfSong == "all")
            {
                foreach (Song name in songs)
                {
                    Console.WriteLine(name.NameOfSong);
                }
            }
            else
            {
                foreach (Song name in songs)
                {
                    if (name.TypeList == typeOfSong)
                    {
                        Console.WriteLine(name.NameOfSong);
                    }
                }
            }

        }
    }
    public class Song
    {

        public string TypeList { get; set; }
        public string NameOfSong { get; set; }
        public string TimeOfSong { get; set; }

    }
}

