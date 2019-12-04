using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace MusicPlaylistAnalyzer
{
    class Program
    {

        static void Main(string[] args)
        {
            Song[] songs = new Song[1500];
            StreamReader sr = new StreamReader("SampleMusicPlaylist.txt");
            StreamWriter sw = new StreamWriter("MusicPlaylistReport.txt");
            Console.WriteLine(sr.ReadLine());
            int i = 0;
            while (!(sr.EndOfStream))
            {
                songs[i] = ReadTabValue();
                
                i++;
                
            }

            string report = "";

            report += "Music Playlist Report\n";
            //Linq
            //How many songs recieved 200 or more plays?
            report += ("How many songs recieved 200 or more plays?");
            //Console.WriteLine("sorry");
            IEnumerable<Song> twohundredormoreplays =
                from Song in songs
                where Song.plays >= 200
                select Song;
            foreach (Song song in twohundredormoreplays)
            {
                //Console.WriteLine("iterate me daddy");
                report += song + "\n";
            }
            report += ("How many songs are in the playlist with the Genre of \"Alternative?\"\n");

            var songswithgenrealternative = from Song in songs where Song.genre == "Alternative" select Song;
            foreach (Song song in songswithgenrealternative)
            {
                report += song + "\n";
            }


            sw.WriteLine(report);

            Song ReadTabValue()
            {
                string line = sr.ReadLine();
                var values = line.Split('\t');
                Song temp = new Song(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7]);
                return temp;
            }
        }

        
    }
}
