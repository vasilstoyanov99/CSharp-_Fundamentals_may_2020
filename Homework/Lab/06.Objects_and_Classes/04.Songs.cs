using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songsList = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] data = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string type = data[0];
                string name = data[1];

                Song newSong = new Song();
                newSong.TypeList = type;
                newSong.Name = name;

                songsList.Add(newSong);
            }

            string listOfSongsToPrint = Console.ReadLine();

            if (listOfSongsToPrint == "all")
            {
                foreach (var currSongData in songsList)
                {
                    Console.WriteLine(currSongData.Name);
                }
            }
            else
            {
                foreach (var currSongData in songsList)
                {
                    if (currSongData.TypeList == listOfSongsToPrint)
                    {
                        Console.WriteLine(currSongData.Name);
                    }
                }
            }
        }

        public class Song
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
        }
    }
}
