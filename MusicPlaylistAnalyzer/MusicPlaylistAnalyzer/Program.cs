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
            List<Song> songs = new List<Song>();
            StreamReader sr = File.OpenText(args[0]);
            using StreamWriter sw = new StreamWriter(args[1]);
            sr.ReadLine();
            
            while (!(sr.EndOfStream))
            {
                songs.Add(ReadTabValue());
            }

            string report = "";
            // First LINQ
            report += "Music Playlist Report\n";

            report += "\n\nHow many songs recieved 200 or more plays?\n";

            var twohundredormoreplays =
                from Song in songs
                where Song.plays >= 200
                select Song;
            foreach (Song song in twohundredormoreplays)
            {
                report += song + "\n";
            }
            report += "\n\nHow many songs are in the playlist with the Genre of \"Alternative?\"\n";

            var songswithgenrealternative =
                (from Song in songs
                where Song.genre == "Alternative"
                select Song).Count();
                report += String.Format("Number of songs with genre alternative: {0}\n", songswithgenrealternative);

            report += "\n\nHow many songs are in the playlist with the Genre of \"Hip-Hop/Rap\"\n";

            var songwithgenreHipHopRap =
                (from Song in songs
                where Song.genre == "Hip-Hop/Rap"
                select Song).Count();

            report += "Number of songs with genre Hip-Hop Rap:" + songwithgenreHipHopRap + "\n";
            
            report += "\n\nWhat songs are in the playlist from the album \"Welcome to the Fishbowl\"\n";

            var songinalbumwelcometothefishbowl =
                from Song in songs
                where Song.album == "Welcome to the Fishbowl"
                select Song;
            foreach (var song in songinalbumwelcometothefishbowl)
            {
                report += song + "\n";
            }
            report += "\n\nWhat are the songs in the playlist from before 1970?\n";

            var songbeforeyear1970 =
                from Song in songs
                where Song.year < 1970
                select Song;
            foreach (var song in songbeforeyear1970)
            {
                report += song + "\n";
            }
            report += "\n\nWhat are the song names that are more than 85 characters long?\n";

            var songslongerthan85characters =
                from Song in songs
                where Song.songName.Length > 85
                select Song;
            foreach (var song in songslongerthan85characters)
            {
                report += song + "\n";
            }
            report += "\n\nWhat is the longest song?\n";

            var longestsonginplaylist =
                (from Song in songs
                 select Song.time).Max();
            report += longestsonginplaylist + "\n";

            sw.Write("hey");
            sw.Write(report);
            Console.WriteLine(report);
            
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
