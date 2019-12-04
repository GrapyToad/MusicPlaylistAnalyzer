using System;
namespace MusicPlaylistAnalyzer
{
    public class Song
    {
        public string songName;
        public string artistName;
        public string album;
        public string genre;
        public int size;
        public int time;
        public int year;
        public int plays;

        public Song(string sn, string an, string al, string ge, string si, string ti, string ye, string pl)
        {
            this.songName = sn;
            this.artistName = an;
            this.album = al;
            this.genre = ge;
            this.size = Convert.ToInt32(si);
            this.time = Convert.ToInt32(ti);
            this.year = Convert.ToInt32(ye);
            this.year = Convert.ToInt32(pl);
        }
        override public string ToString()
        {
            return String.Format("Name: {0}, Artist: {1}, Album: {2}, Genre: {3}, Size: {4}, Time: {5}, Year: {6}, Plays: {7}", songName, artistName, album, genre, size, time, year, plays);
        }

    }
}
