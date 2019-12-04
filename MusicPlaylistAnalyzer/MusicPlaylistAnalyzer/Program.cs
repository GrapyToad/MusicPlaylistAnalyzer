using System;
using System.IO;

namespace MusicPlaylistAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Song[] songs = new Song[1500];
            StreamReader sr = new StreamReader("/Users/gradytodd/HDD/Projects 2040/MusicPlaylistAnalyzer");
            Console.WriteLine(sr.ReadLine());

        }
    }
}
