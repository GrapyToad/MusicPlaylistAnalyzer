using System;
namespace MusicPlaylistAnalyzer
{
    public class Song
    {
        string songName;
        string artistName;
        string album;
        string genre;
        int size;
        int time;
        int year;
        int plays;

        public Song()
        {
        }
        override public string ToString()
        {
            return String.Format("Name: {0}, Artist: {1}, Album: {2}, Genre: {3}, Size: {4}, Time: {5}, Year: {6}, Plays: {7}", songName, artistName, album, genre, size, time, year, plays);
        }

    }
}
