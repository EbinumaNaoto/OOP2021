using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {

        static void Main(string[] args) {
            //2.1.3
            var songs = new Song[3];
            songs[0] = new Song("光、再考", "amazarashi", 339);
            songs[1] = new Song("つじつま合わせに生まれた僕等", "amazarashi", 340);
            songs[2] = new Song("少年少女", "amazarashi", 345);
            PrintSongs(songs);
        }

        //2.1.4
        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                Console.WriteLine($"アーティスト名: {song.ArtistName}");
                Console.WriteLine($"タイトル: {song.Title}");
                Console.WriteLine("演奏時間: " + (song.Length / 60) + ":" + (song.Length % 60));
                Console.WriteLine();
            }
        }
    }
}
